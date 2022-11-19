using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodClick : MonoBehaviour
{
    public static int count;
    public static int badCount;

    private void Start()
    {
        count=0;
        badCount=0;
    }

    public void click() {
        foodClick.count += 1;
    }

    public void bedClick() { 
        foodClick.badCount += 1;


    }



}
