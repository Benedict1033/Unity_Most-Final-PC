using System;
using UnityEngine;
using UnityEngine.UI;

public class BackEnd1 : MonoBehaviour
{
    public int choose = 0;

    public Text[] someText;
    public string str;

    public int userId;

    public Text sexText;

    public Text user;

    public int total_E;
    public int total_N;
    public int total_H;

    public Text[] texttt;
    public Text[] per;

    private void Start()
    {

        total_E = 0;
        total_N = 0;
        total_H = 0;
    }

    public void man45()
    {
        choose = 1;
        PlayerPrefs.SetInt("sex" + SceneManagment.people, choose);
    }

    public void man56()
    {
        choose = 2;
        PlayerPrefs.SetInt("sex" + SceneManagment.people, choose);
    }

    public void women45()
    {
        choose = 3;
        PlayerPrefs.SetInt("sex" + SceneManagment.people, choose);
    }

    public void women56()
    {
        choose = 4;
        PlayerPrefs.SetInt("sex" + SceneManagment.people, choose);
    }

    public void show() {
        total_E = 0;
        total_N = 0;
        total_H = 0;

        string abc = user.text;

        userId = int.Parse(abc);

        choose = 0;
        string str = "";

        if (PlayerPrefs.GetInt("sex" + (-1 + userId)) == 1)
        {
            str = "4-5 years old boy .";
        }
        else if (PlayerPrefs.GetInt("sex" + (-1 + userId)) == 2)
        {
            str = "5-6 years old boy .";
        }
        else if (PlayerPrefs.GetInt("sex" + (-1 + userId)) == 3)
        {
            str = "4-5 years old girl .";
        }
        else if (PlayerPrefs.GetInt("sex" + (-1 + userId)) == 4)
        {
            str = "5-6 years old girl .";
        }

        sexText.text = "i'm " + "user " + (userId) + ".I'm  " + str;


        // 1 score ////////////////////////////////////////////////
        string score__1="";
        int score_1 = PlayerPrefs.GetInt("1.easy" + userId) + PlayerPrefs.GetInt("1.1.easy" + userId);

        if (score_1 == 0) { 
            score__1 = "5分";
            total_E += 5;
        }
        else if (score_1 == 1)
        {
            score__1 = "4分";
            total_E += 4;

        }
        else if (score_1 == 2)
        {
            score__1 = "3分";
            total_E += 3;


        }
        else if (score_1 == 3)
        {
            score__1 = "2分";
            total_E += 2;

        }
        else { 
            score__1 = "1分";
            total_E += 1;

        }

        someText[0].text = score__1;

        string score__2 = "";
        int score_2 = PlayerPrefs.GetInt("1.normal" + userId) + PlayerPrefs.GetInt("1.1.normal" + userId);

        if (score_2 == 0)
        {
            score__2 = "5分";
            total_N += 5;

        }
        else if (score_2 == 1)
        {
            score__2 = "4分";
            total_N += 4;

        }
        else if (score_2 == 2)
        {
            score__2 = "3分";
            total_N += 3;


        }
        else if (score_2 == 3)
        {
            score__2 = "2分";
            total_N += 2;

        }
        else
        {
            score__2 = "1分";
            total_N += 1;

        }

        someText[1].text = score__2;

        string score__3 = "";
        int score_3 = PlayerPrefs.GetInt("1.hard" + userId) + PlayerPrefs.GetInt("1.1.hard" + userId);

        if (score_3 == 0)
        {
            score__3 = "5分";
            total_H += 5;

        }
        else if (score_3 == 1)
        {
            score__3 = "4分";
            total_H += 4;

        }
        else if (score_3 == 2)
        {
            score__3 = "3分";
            total_H += 3;


        }
        else if (score_3 == 3)
        {
            score__3 = "2分";
            total_H += 2;

        }
        else
        {
            score__3 = "1分";
            total_H += 1;

        }

        someText[2].text = score__3;



        int a = (total_E + total_N + total_H);
        texttt[3].text =a.ToString();

        // 2 score //////////////////////////////////////////////

        string score2 = "";

    

            if (PlayerPrefs.GetInt("2.easyTime" + userId) <= 10)
            {
                score2 = "5分";
            total_E += 5;


        }
        else if (PlayerPrefs.GetInt("2.easyTime" + userId) > 10 && PlayerPrefs.GetInt("2.easyTime" + userId) <= 15)
            {
                score2 = "3分";
            total_E += 3;

        }
        else if (PlayerPrefs.GetInt("2.easyTime" + userId) >= 15)
            {
                score2 = "1分";
            total_E += 1;

        }


        someText[3].text = score2;

        string score2_2 = "";

        if (PlayerPrefs.GetInt("2.normalTime" + userId) <= 10)
        {
            score2_2 = "5分";
            total_N += 5;


        }
        else if (PlayerPrefs.GetInt("2.normalTime" + userId) > 10 && PlayerPrefs.GetInt("2.normalTime" + userId) <= 15)
        {
            score2_2 = "3分";
            total_N += 3;


        }
        else if (PlayerPrefs.GetInt("2.normalTime" + userId) >= 15)
        {
            score2_2 = "2分";
            total_N += 2;


        }

        someText[4].text = score2_2;


        string score2_3 = "";

        if (PlayerPrefs.GetInt("2.hardTime" + userId) <= 10)
        {
            score2_3 = "5分";
            total_H += 5;


        }
        else if (PlayerPrefs.GetInt("2.hardTime" + userId) > 10 && PlayerPrefs.GetInt("2.hardTime" + userId) <= 15)
        {
            score2_3 = "3分";
            total_H += 3;


        }
        else if (PlayerPrefs.GetInt("2.hardTime" + userId) >= 15)
        {
            score2_3 = "1分";
            total_H += 1;


        }

        someText[5].text = score2_3;


        int b = (total_E + total_N + total_H)-a;
        texttt[4].text = b.ToString();

        //3 score ////////////////////////////////////////////////

        string ans = "";
        if (PlayerPrefs.GetInt("3.easy" + userId).ToString() == "0")
        {

            ans = "5";
            total_E += 5;

        }

        else if (PlayerPrefs.GetInt("3.easy" + userId).ToString() == "1")
        {

            ans = "4";
            total_E += 4;

        }
        else if (PlayerPrefs.GetInt("3.easy" + userId).ToString() == "2")
        {

            ans = "3";
            total_E += 3;

        }
        else {
            ans = "1";
            total_E += 1;

        }


        someText[6].text = ans + "分";


        string ans1 = "";
        if (PlayerPrefs.GetInt("3.normal" + userId).ToString() == "0")
        {

            ans1 = "5";
            total_N += 5;

        }

        else if (PlayerPrefs.GetInt("3.normal" + userId).ToString() == "1")
        {

            ans1 = "4";
            total_N += 4;

        }
        else if (PlayerPrefs.GetInt("3.normal" + userId).ToString() == "2")
        {

            ans1 = "3";
            total_N += 3;

        }
        else
        {
            ans1 = "1";
            total_N += 1;

        }

        someText[7].text = ans1 + "分";


        string ans2 = "";
        if (PlayerPrefs.GetInt("3.hard" + userId).ToString() == "0")
        {

            ans2 = "5";
            total_H += 5;

        }

        else if (PlayerPrefs.GetInt("3.hard" + userId).ToString() == "1")
        {

            ans2 = "4";
            total_H += 4;

        }
        else if (PlayerPrefs.GetInt("3.hard" + userId).ToString() == "2")
        {

            ans2 = "3";
            total_H += 3;

        }
        else
        {
            ans2 = "1";
            total_H += 1;

        }

        someText[8].text = ans2+"分";

        int c = (total_E + total_N + total_H) - b-a;
        texttt[5].text = c.ToString();

        // 4 score ///////////////////////////////////////////////////////////
        string score4;

        if (PlayerPrefs.GetInt("4.easyTime" + userId) <= 15)
        {
            score4 = "5分";
            total_E += 5;

        }
        else if (PlayerPrefs.GetInt("4.easyTime" + userId) > 15 && PlayerPrefs.GetInt("4.easyTime" + userId) <= 20)
        {
            score4 = "3分";
            total_E += 3;


        }
        else { score4 = "1分";
            total_E += 1;
        }

        someText[9].text = score4;


        string score4_2;

        if (PlayerPrefs.GetInt("4.normalTime" + userId) <25 )
        {
            score4_2 = "5分";
            total_N += 5;

        }
        else if (PlayerPrefs.GetInt("4.normalTime" + userId) > 25 && PlayerPrefs.GetInt("4.normalTime" + userId) <= 30)
        {
            score4_2 = "3分";
            total_N += 3;


        }
        else { score4_2 = "1分";
            total_N += 1;
        }

        someText[10].text = score4_2;


        string score4_3;

        if (PlayerPrefs.GetInt("4.hardTime" + userId) < 30)
        {
            score4_3 = "5分";
            total_H += 5;

        }
        else if (PlayerPrefs.GetInt("4.hardTime" + userId) > 30 && PlayerPrefs.GetInt("4.hardTime" + userId) <= 35)
        {
            score4_3 = "3分";
            total_H += 3;


        }
        else { score4_3 = "1分";
            total_H += 1;
        }

        someText[11].text = score4_3;


        int d = (total_E + total_N + total_H) - c-b-a;
        texttt[6].text = d.ToString();

        //5 score ///////////////////////////////////////////////////////

        int score5 =0;

        if (PlayerPrefs.GetInt("5.1.choose" + userId) == 1)
        {
            score5 = 1;
            total_E += 1;

        }
        else if (PlayerPrefs.GetInt("5.1.choose" + userId) == 2)
        {
            score5 = 3;
            total_E += 3;

        }

        if (PlayerPrefs.GetInt("5.easyTime" + userId) >= 5)
        {
            score5 += 1;
            total_E += 1;

        }
        else {
            score5 += 2;
            total_E += 2;

        }

        someText[12].text = score5.ToString() + "分";

        int score5_1 = 0;

        if (PlayerPrefs.GetInt("5.trash" + userId) == 1)
        {

            score5_1 = 1;
            total_N += 1;


        }
        else if (PlayerPrefs.GetInt("5.trash" + userId) == 2)
        {

            score5_1 = 2;
            total_N += 2;


        }
        else if (PlayerPrefs.GetInt("5.trash" + userId) == 3)
        {

            score5_1 = 3;
            total_N += 3;


        }
        else if (PlayerPrefs.GetInt("5.trash" + userId) == 4)
        {

            score5_1 = 4;
            total_N += 4;


        }
        else if (PlayerPrefs.GetInt("5.trash" + userId) == 5)
        {

            score5_1 = 5;
            total_N += 5;


        }

        someText[13].text = score5_1.ToString() + "分";


        int score5_2 = 0;

        if (PlayerPrefs.GetInt("5.3.choose" + userId) == 1)
        {
            score5_2 = 1;
            total_H += 1;

        }
        else if (PlayerPrefs.GetInt("5.3.choose" + userId) == 2)
        {
            score5_2 = 3;
            total_H += 3;

        }
        else if (PlayerPrefs.GetInt("5.3.choose" + userId) == 3)
        {
            score5_2 = 5;
            total_H += 5;

        }

        if (PlayerPrefs.GetInt("5.3.bedchoose" + userId) >= 1) {

            if (score5_2 >= 3)
            {
                score5_2 -= 2;
                total_H -= 2;

            }


        }

        someText[14].text = score5_2.ToString() + "分";


        int e = (total_E + total_N + total_H) -d- c - b - a;
        texttt[7].text = e.ToString();


        //6 score  /////////////////////////////////////////////////////
        string score = "";
        if (PlayerPrefs.GetInt("6.easyTime" + userId) <= 3)
        {
            score = "5分";
            total_E += 5;


        }
        else if (PlayerPrefs.GetInt("6.easyTime" + userId) >3 && PlayerPrefs.GetInt("6.easyTime" + userId) <= 7) { 
            score = "3分";
            total_E += 3;


        }
        else if (PlayerPrefs.GetInt("6.easyTime" + userId) >= 8)
        {
            score = "1分";
            total_E += 1;


        }


        someText[15].text = score;

        if (PlayerPrefs.GetInt("6.normalTime" + userId) <= 3)
        {
            score = "5分";
            total_N += 5;


        }
        else if (PlayerPrefs.GetInt("6.normalTime" + userId) > 3 && PlayerPrefs.GetInt("6.normalTime" + userId) <= 7)
        {
            score = "3分";
            total_N += 3;


        }
        else if (PlayerPrefs.GetInt("6.normalTime" + userId) >= 8)
        {
            score = "1分";
            total_N += 1;


        }


        someText[16].text = score;

        if (PlayerPrefs.GetInt("6.hardTime" + userId) <= 5)
        {
            score = "5分";
            total_H += 5;


        }
        else if (PlayerPrefs.GetInt("6.hardTime" + userId) > 5 && PlayerPrefs.GetInt("6.hardTime" + userId) <= 6)
        {
            score = "4分";
            total_H += 4;


        }
        else if (PlayerPrefs.GetInt("6.hardTime" + userId) > 6 && PlayerPrefs.GetInt("6.hardTime" + userId) <= 7)
        {
            score = "3分";
            total_H += 3;


        }
        else if (PlayerPrefs.GetInt("6.hardTime" + userId) > 7 && PlayerPrefs.GetInt("6.hardTime" + userId) <= 8)
        {
            score = "2分";
            total_H += 2;


        }
        else if (PlayerPrefs.GetInt("6.hardTime" + userId) > 8)
        {
            score = "1分";
            total_H += 1;


        }


        someText[17].text = score;

        int f = (total_E + total_N + total_H)- e- d - c - b - a;
        texttt[8].text = f.ToString();


        texttt[0].text = total_E.ToString();
        texttt[1].text = total_N.ToString();
        texttt[2].text = total_H.ToString();

      


       per[0].text= (Math.Round((float)a/15*100))+"%".ToString();
       per[1].text= (Math.Round((float)b/15*100))+"%".ToString();
       per[2].text= (Math.Round((float)c/15*100))+"%".ToString();
       per[3].text= (Math.Round((float)d/15*100))+"%".ToString();
       per[4].text= (Math.Round((float)e/15*100))+"%".ToString();
       per[5].text= (Math.Round((float)f/15*100))+"%".ToString();  
        
        per[6].text= (Math.Round((float)total_E / 30*100))+"%".ToString();
        per[7].text= (Math.Round((float)total_N / 30*100))+"%".ToString();
        per[8].text= (Math.Round((float)total_H / 30*100))+"%".ToString();


    }
}
