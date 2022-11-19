using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Together_Hard_Mom : MonoBehaviour
{
    public GameObject[] Btn;
    public static int count;
    public static int eggCount;
    public static int ovenCount;

    public GameObject[] obj;

    public Text sonText;
    public AudioSource sound;


    private void Start()
    {
        count = 0;
        eggCount = 0;
        ovenCount = 0;
    }
    public void clickW()
    {
        Together_Hard_Mom.count++;
        if (count == 2)
        {
            obj[2].SetActive(true);
            sonText.text = "小朋友請點擊攪拌";

        }
        else
        {
            obj[0].SetActive(true);


        }
    }

    public void clickF()
    {
        Together_Hard_Mom.count++;
        if (count == 2)
        {
            sonText.text = "家長請點擊攪拌";
            sound.Play();


            obj[2].SetActive(true);

        }
        else
        {
            obj[1].SetActive(true);
        }
    }

    public void mix()
    {
        Together_Hard_Mom.count++;
        if (count == 3)
        {
            Btn[0].SetActive(true);
        }
    }

    public void egg()
    {
        Together_Hard_Mom.eggCount++;
        if (eggCount == 3)
        {
            Btn[0].SetActive(true);
        }
    }

    public void oven()
    {
        Together_Hard_Mom.ovenCount++;
        if (ovenCount == 3)
        {
            Btn[1].SetActive(true);
            Btn[2].SetActive(false);
        }
    }

}
