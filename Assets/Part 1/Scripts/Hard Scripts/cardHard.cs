﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardHard : MonoBehaviour
{
    public bool faceUp, locked;
    public static bool corotineAllowed;
    private cardHard firstInPair, secondInPair;
    private string firstInPairName, secondInPairName;
    public static Queue<cardHard> sequence;
    public static int pairsFound;

    public AudioSource trueSound;
    public AudioSource falseSound;
    public Text instructionText;
    public GameObject nextText;

    public GameObject[] cardPreview;

    public GameObject[] collider;

    public AudioSource soundd;

   
    public static int wrongCount = 0;

    private void Start()
    {
        faceUp = false;
        corotineAllowed = true;
        locked = false;
        sequence = new Queue<cardHard>();
        pairsFound = 0;
        wrongCount = 0;

        Invoke("startInstrution", 10);
    }

    private void OnMouseDown()
    {
        if (!locked && corotineAllowed)
        {
            StartCoroutine(RotateCard());
            transform.GetChild(2).gameObject.SetActive(false);
        }
    }

    public IEnumerator RotateCard()
    {
        yield return new WaitForSeconds(0f);

        corotineAllowed = false;

        if (!faceUp)
        {
            sequence.Enqueue(this);
        }
        else if (faceUp)
        {
            sequence.Clear();
        }

        corotineAllowed = true;
        faceUp = !faceUp;

        if (sequence.Count == 2)
        {
            CheckResults();
        }
    }

    private void CheckResults()
    {
        firstInPair = sequence.Dequeue();
        secondInPair = sequence.Dequeue();

        firstInPairName = firstInPair.name.Substring(0, firstInPair.name.Length - 1);
        secondInPairName = secondInPair.name.Substring(0, secondInPair.name.Length - 1);

        if (firstInPairName == secondInPairName)
        {
            firstInPair.locked = true;
            secondInPair.locked = true;
            pairsFound += 1;

            firstInPair.StartCoroutine("truePair");
            secondInPair.StartCoroutine("truePair");

            trueSound.Play();

            instructionText.text = "你好棒喔!";
        }
        else
        {

            firstInPair.StartCoroutine("RotateBack");
            secondInPair.StartCoroutine("RotateBack");

            firstInPair.StartCoroutine("wrongPair");
            secondInPair.StartCoroutine("wrongPair");

            falseSound.Play();

            instructionText.text = "沒關係\n再試一次!";
           cardHard.wrongCount += 1;
        }

        if (pairsFound == 3)
        {
            instructionText.text = "你完成了，輕點繼續下一個遊戲";
            nextText.SetActive(true);
        }
    }

    public IEnumerator RotateBack()
    {
        corotineAllowed = false;
        yield return new WaitForSeconds(0.2f);

        sequence.Clear();

        faceUp = false;

        corotineAllowed = true;

        StartCoroutine(cardRotate());
    }

    public IEnumerator truePair()
    {
        yield return new WaitForSeconds(0);
        transform.GetChild(1).gameObject.SetActive(true);

        transform.GetChild(2).GetComponent<SpriteRenderer>().sortingOrder = 0;
    }

    public IEnumerator wrongPair()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }

    public IEnumerator cardRotate()
    {
        yield return new WaitForSeconds(0);

        for (float j = 180f; j >= 0; j -= 10f)
        {
            transform.rotation = Quaternion.Euler(0f, j, 0f);
            yield return new WaitForSeconds(0.01f);
        }

        for (int i = 0; i <= 5; i++)
        {
            cardPreview[i].SetActive(true);
        }
    }


    void startInstrution()
    {
        StartCoroutine(cardRotate());
        instructionText.text = "小朋友\n，請點擊相同的圖片";
        soundd.Play();
        for (int i = 0; i <= 5; i++)
        {
            collider[i].GetComponent<Collider2D>().enabled = true;
        }
       
    }
}
