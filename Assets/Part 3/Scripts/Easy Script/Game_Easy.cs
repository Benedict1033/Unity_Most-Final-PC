using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Easy : MonoBehaviour
{
    public Text win;
    public GameObject nextText;

    public static int wrongCount;

    private void Start()
    {
        wrongCount = 0;
    }

    public void click() {

        transform.GetChild(0).gameObject.SetActive(true);
        Invoke("close", 0.5f);
    }

     void close() {
        if (transform.name != "月餅")
        {
            transform.GetChild(0).gameObject.SetActive(false);
            win.text = "沒關係，再一次";
            Game_Easy.wrongCount += 1;
        }

        else
        {
            win.text = "你好棒喔，輕點繼續下一個難度";
            nextText.SetActive(true);
        }
    }
}
