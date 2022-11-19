using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Hard : MonoBehaviour
{
    public Text win;
    public GameObject nextText;
    public static int count;
    public static int wrongCount;


    private void Start()
    {
        count = 0;
        wrongCount = 0;
    }

    public void click() {

        transform.GetChild(0).gameObject.SetActive(true);
        Invoke("close", 0.5f);
    }

     void close() {
        if (transform.name != "柚子")
        {
            transform.GetChild(0).gameObject.SetActive(false);
            win.text = "沒關係，再一次";
            Game_Hard.wrongCount += 1;
        }

        else 
        {
            Game_Normal.count += 1;
            win.text = "你好棒喔，輕點繼續下一個遊戲吧";
            gameObject.GetComponent<Button>().enabled = false;
            nextText.gameObject.SetActive(true);
        }
    }
}
