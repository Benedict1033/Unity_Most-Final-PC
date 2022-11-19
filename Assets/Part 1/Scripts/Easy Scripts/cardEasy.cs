using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardEasy : MonoBehaviour
{
    public bool faceUp, locked;
    public static bool corotineAllowed;
    private cardEasy firstInPair, secondInPair;
    private string firstInPairName, secondInPairName;
    public static Queue<cardEasy> sequence;
    public static int pairsFound;

    public AudioSource trueSound;
    public AudioSource falseSound;
    public AudioSource winSound;
    public Text instructionText;
    public GameObject nextText;

    public static int wrongCount; 

    private void Start()
    {
        faceUp = false;
        corotineAllowed = true;
        locked = false;
        sequence = new Queue<cardEasy>();
        pairsFound = 0;
        wrongCount = 0;
    }

    public void OnMouseDown()
    {
        if (!locked && corotineAllowed)
        {
            StartCoroutine(RotateCard());
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(150, 150, 150, 255);
            //print(sequence.Count);
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
         if (faceUp)
        {
            sequence.Clear();
        }

        corotineAllowed = true;
        faceUp = !faceUp;

        //print(sequence.Count);

        if (sequence.Count == 2)
        {
            //print(sequence.Count);
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
            cardEasy.wrongCount += 1;
            print(wrongCount);
            //print("wrong");
            firstInPair.StartCoroutine("RotateBack");
            secondInPair.StartCoroutine("RotateBack");

            firstInPair.StartCoroutine("wrongPair");
            secondInPair.StartCoroutine("wrongPair");

            falseSound.Play();

            instructionText.text = "沒關係\n再試一次!";
        }

        if (pairsFound == 3)
        {
            instructionText.text = "你完成了\n輕點繼續遊戲";
            nextText.SetActive(true);
            winSound.Play();
        }
    }

    public IEnumerator RotateBack()
    {
        corotineAllowed = false;
        yield return new WaitForSeconds(0.2f);

        sequence.Clear();

        faceUp = false;

        corotineAllowed = true;
    }

    public IEnumerator truePair()
    {
        yield return new WaitForSeconds(0);
        transform.GetChild(1).gameObject.SetActive(true);
    }

    public IEnumerator wrongPair()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);

        transform.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
