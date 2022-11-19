using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Together_Hard_Son : MonoBehaviour
{
    public GameObject []Btn;
    public static int count;
    public static int cakeCount;

    public GameObject[] obj;

    public Text sonText;

    public AudioSource sound;

    private void Start()
    {
        count = 0;
        cakeCount = 0;

    }

    public void clickW()
    {
        Together_Hard_Son.count++;
        if (count == 2) {
            obj[2].SetActive(true);
            sonText.text = "小朋友請點擊攪拌";
            sound.Play();
        }
        else
        {
            obj[0].SetActive(true);


        }
    }

    public void clickF()
    {
        Together_Hard_Son.count++;
        if (count == 2)
        {
            sonText.text = "小朋友請點擊攪拌";

            obj[2].SetActive(true);

        }
        else
        {
            obj[1].SetActive(true);
        }
    }

    public void mix() {
        Together_Hard_Son.count++;
        if (count == 3) {
            Btn[0].SetActive(true);
        }
    }

    public void moonCake() {
        Together_Hard_Son.cakeCount++;
        if (cakeCount == 3)
        {
            Btn[1].SetActive(true);
        }
    }

}
