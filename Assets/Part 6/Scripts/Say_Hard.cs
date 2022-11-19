using UnityEngine;

public class Say_Hard : MonoBehaviour
{
    public Camera m_camera;
    public GameObject brush;

    LineRenderer currentLineRenderer;

    Vector2 lastPos;

    public GameObject obj;

    private void Update()
    {
        Drawing();
        try
        {
            obj.transform.position = m_camera.ScreenToWorldPoint(Input.mousePosition);
        }
        catch { }
    }

    void Drawing()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateBrush();
            obj.GetComponent<CircleCollider2D>().enabled = true;

        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            PointToMousePos();
        }
        else
        {
            currentLineRenderer = null;
        }
    }

    void CreateBrush()
    {


        GameObject brushInstance = Instantiate(brush);
        currentLineRenderer = brushInstance.GetComponent <LineRenderer> ();

        //because you gotta have 2 points to start a line renderer, 
        Vector2 Pos = m_camera.ScreenToWorldPoint(Input.mousePosition);

        obj.transform.position = Pos;

        currentLineRenderer.SetPosition(0, Pos);
        currentLineRenderer.SetPosition(1, Pos);


    }

    void AddAPoint(Vector2 pointPos)
    {
        currentLineRenderer.positionCount++;
        int positionIndex = currentLineRenderer.positionCount - 1;
        currentLineRenderer.SetPosition(positionIndex, pointPos);
    }

    void PointToMousePos()
    {
        Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
        if (lastPos != mousePos)
        {
            AddAPoint(mousePos);
            lastPos = mousePos;
        }
    }

}