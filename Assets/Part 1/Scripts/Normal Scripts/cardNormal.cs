using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardNormal : MonoBehaviour
{
    public bool faceUp, locked;
    public static bool corotineAllowed;
    private cardNormal firstInPair, secondInPair;
    private string firstInPairName, secondInPairName;
    public static Queue<cardNormal> sequence;
    public static int pairsFound;

    public AudioSource trueSound;
    public AudioSource falseSound;
    public Text instructionText;
    public GameObject nextText;
    public static int wrongCount=0;

    private void Start()
    {
        faceUp = false;
        corotineAllowed = true;
        locked = false;
        sequence = new Queue<cardNormal>();
        pairsFound = 0;
        wrongCount = 0;
    }

    private void OnMouseDown()
    {
        if (!locked && corotineAllowed)
        {
            StartCoroutine(RotateCard());
            transform.GetChild(2).gameObject.SetActive(true);
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
            cardNormal.wrongCount += 1;
        }

        if (pairsFound == 3)
        {
            instructionText.text = "你完成了\n輕點繼續遊戲";
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
    }

    public IEnumerator truePair()
    {
        yield return new WaitForSeconds(0);
        transform.GetChild(1).gameObject.SetActive(true);
    }

    public IEnumerator wrongPair()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }
}
