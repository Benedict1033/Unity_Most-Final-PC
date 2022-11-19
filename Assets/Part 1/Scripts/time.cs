using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour
{
    // Start is called before the first frame update
    public static float timeRemaining = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining += Time.deltaTime;
    }
}
