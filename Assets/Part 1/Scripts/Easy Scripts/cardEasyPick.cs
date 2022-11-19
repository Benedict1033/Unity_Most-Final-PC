using UnityEngine;
using UnityEngine.UI;

public class cardEasyPick : MonoBehaviour
{
    public Text instructionText;
    public GameObject nextText;
    public AudioSource winSound;

    public static int wrongCount;

    private void Start()
    {
        wrongCount = 0;
    }

    public void pick() 
    {
        GetComponent<AudioSource>().Play();

        if (transform.gameObject.name == "兔子")
        {
        }

        if (transform.gameObject.name == "兔子")
        {
            transform.GetChild(0).gameObject.SetActive(true);
            instructionText.text = "你答對了\n繼續挑戰下一個難度吧!";
            nextText.SetActive(true);
            winSound.Play();

        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(true);
            instructionText.text = "沒關係，再試一次吧!";
            Invoke("closePic", 0.4f);
            cardEasyPick.wrongCount += 1;
        }

    }

    void closePic()=>transform.GetChild(0).gameObject.SetActive(false);
    
}
