﻿using UnityEngine;
using UnityEngine.UI;

public class Game_Manager_Normal : MonoBehaviour
{
    public GameObject flyButton;
    public Animator anim;
    public static int count = 0;
    public Transform shapeContainer;
    public AudioSource winSound;
    public Text winText;
    public GameObject nextText;
    public static bool circleChoose = false;
    public static bool squareChoose = false;
    //public static float time;

    private void Start()
    {
        count = 0;
        circleChoose = false;
        squareChoose = false;
        //time = 0;
    }
    private void Update()
    {
        if (count >= 2&&circleChoose&& squareChoose) {
            flyButton.SetActive(true);
        }

        //time += Time.deltaTime;
    }

    public void clickShapeT1()
    {
        RectTransform rect = GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(553, 100);
        Game_Manager_Normal.count += 1;
        transform.parent = shapeContainer;
    }

    public void clickShapeT2()
    {
        RectTransform rect = GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(470, 100);
        Game_Manager_Normal.count += 1;
        transform.parent = shapeContainer;
    }

    public void clickShapeR1()
    {
        RectTransform rect = GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(557, 20);
        Game_Manager_Normal.count += 1;
        transform.parent = shapeContainer;
    }

    public void clickShapeR2()
    {
        RectTransform rect = GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(470, 20);
        Game_Manager_Normal.count += 1;
        transform.parent = shapeContainer;
    }

    public void clickShapeC1()
    {
        Game_Manager_Normal.circleChoose = true;
        RectTransform rect = GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(555.5f, -135.5f);
        Game_Manager_Normal.count += 1;
        transform.parent = shapeContainer;
    }

    public void clickShapeC2()
    {
        Game_Manager_Normal.circleChoose = true;
        RectTransform rect = GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(474, -135.5f);
        Game_Manager_Normal.count += 1;
        transform.parent = shapeContainer;
    }

    public void clickShapeS1()
    {
        RectTransform rect = GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(556, -59f);
        Game_Manager_Normal.count += 1;
        transform.parent = shapeContainer;
        Game_Manager_Normal.squareChoose = true;
    }

    public void clickShapeS2()
    {
        RectTransform rect = GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(470, -59f);
        Game_Manager_Normal.count += 1;
        transform.parent = shapeContainer;
        Game_Manager_Normal.squareChoose = true;
    }

    public void fly()
    {
        count = 0;
        anim.SetBool("Fly", true);
        Invoke("win", 5.5f);
        flyButton.SetActive(false);
    }

    void win() {

        winSound.Play();
        winText.text = "你好棒喔,繼續下一個難度吧！";
        shapeContainer.gameObject.SetActive(false);
        nextText.SetActive(true);
    }
}
