using System;
using UnityEngine;
using UnityEngine.UI;

public class BackEnd : MonoBehaviour
{
    public int choose = 0;

    public Text[] someText;
    public string str;

    public int userId;

    public Text sexText;

    public Text user;

    public Text []time;

    private void Start()
    {
      

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

        // total
        int a = PlayerPrefs.GetInt("1.easyTime" + userId) + PlayerPrefs.GetInt("1.normalTime" + userId) + PlayerPrefs.GetInt("1.hardTime" + userId);
        time[0].text = a.ToString();
        int b = PlayerPrefs.GetInt("2.easyTime" + userId) + PlayerPrefs.GetInt("2.normalTime" + userId) + PlayerPrefs.GetInt("2.hardTime" + userId);
        time[1].text = b.ToString();
        int c = PlayerPrefs.GetInt("3.easyTime" + userId) + PlayerPrefs.GetInt("3.normalTime" + userId) + PlayerPrefs.GetInt("3.hardTime" + userId);
        time[2].text = c.ToString();
        int d = PlayerPrefs.GetInt("4.easyTime" + userId) + PlayerPrefs.GetInt("4.normalTime" + userId) + PlayerPrefs.GetInt("4.hardTime" + userId);
        time[3].text = d.ToString();
        int e = PlayerPrefs.GetInt("5.easyTime" + userId) + PlayerPrefs.GetInt("5.normalTime" + userId) + PlayerPrefs.GetInt("5.hardTime" + userId);
        time[4].text = e.ToString();
        int f = PlayerPrefs.GetInt("6.easyTime" + userId) + PlayerPrefs.GetInt("6.normalTime" + userId) + PlayerPrefs.GetInt("6.hardTime" + userId);
        time[5].text = f.ToString();

        int a1 = PlayerPrefs.GetInt("1.easyTime" + userId) + PlayerPrefs.GetInt("2.easyTime" + userId) + PlayerPrefs.GetInt("3.easyTime" + userId) + PlayerPrefs.GetInt("4.easyTime" + userId)+ PlayerPrefs.GetInt("5.easyTime" + userId) + PlayerPrefs.GetInt("6.easyTime" + userId);
        time[6].text = a1.ToString();
        int b1 = PlayerPrefs.GetInt("1.normalTime" + userId) + PlayerPrefs.GetInt("2.normalTime" + userId) + PlayerPrefs.GetInt("3.normalTime" + userId) + PlayerPrefs.GetInt("4.normalTime" + userId) + PlayerPrefs.GetInt("5.normalTime" + userId) + PlayerPrefs.GetInt("6.normalTime" + userId);
        time[7].text = b1.ToString();
        int c1 = PlayerPrefs.GetInt("1.hardTime" + userId) + PlayerPrefs.GetInt("2.hardTime" + userId) + PlayerPrefs.GetInt("3.hardTime" + userId) + PlayerPrefs.GetInt("4.hardTime" + userId) + PlayerPrefs.GetInt("5.hardTime" + userId) + PlayerPrefs.GetInt("6.hardTime" + userId);
        time[8].text = c1.ToString();
   



        //1 wrong
        someText[0].text = PlayerPrefs.GetInt("1.easy" + userId).ToString();
        someText[1].text = PlayerPrefs.GetInt("1.1.easy" + userId).ToString();
        someText[2].text = PlayerPrefs.GetInt("1.normal" + userId).ToString();
        someText[3].text = PlayerPrefs.GetInt("1.1.normal" + userId).ToString();
        someText[4].text = PlayerPrefs.GetInt("1.hard" + userId).ToString();
        someText[5].text = PlayerPrefs.GetInt("1.1.hard" + userId).ToString();
        //1 sec
        someText[6].text = PlayerPrefs.GetInt("1.easyTime" + userId).ToString();
        someText[7].text = PlayerPrefs.GetInt("1.normalTime" + userId).ToString();
        someText[8].text = PlayerPrefs.GetInt("1.hardTime" + userId).ToString();
       

        //2 sec
        someText[9].text  = PlayerPrefs.GetInt("2.easyTime" + userId).ToString();
        someText[10].text = PlayerPrefs.GetInt("2.normalTime" + userId).ToString();
        someText[11].text = PlayerPrefs.GetInt("2.hardTime" + userId).ToString();

        

        //3 wrong
        someText[12].text = PlayerPrefs.GetInt("3.easy" + userId).ToString();
        someText[13].text = PlayerPrefs.GetInt("3.normal" + userId).ToString();
        someText[14].text = PlayerPrefs.GetInt("3.hard" + userId).ToString();

        //3 sec
        someText[15].text = PlayerPrefs.GetInt("3.easyTime" + userId).ToString();
        someText[16].text = PlayerPrefs.GetInt("3.normalTime" + userId).ToString();
        someText[17].text = PlayerPrefs.GetInt("3.hardTime" + userId).ToString();
       

        //4 sec
        someText[18].text = PlayerPrefs.GetInt("4.easyTime" + userId).ToString();
        someText[19].text = PlayerPrefs.GetInt("4.normalTime" + userId).ToString();
        someText[20].text = PlayerPrefs.GetInt("4.hardTime" + userId).ToString();

        



        if (PlayerPrefs.GetInt("4.1.choose" + userId) == 1)
        {
            str = "mom";
        }
        else if (PlayerPrefs.GetInt("4.1.choose" + userId) == 2)
        {
            str = "dad";
        }
        else if (PlayerPrefs.GetInt("4.1.choose" + userId) == 3)
        {
            str = "son";
        }
        else if (PlayerPrefs.GetInt("4.1.choose" + userId) == 4)
        {
            str = "sis";
        }

        someText[21].text = str;


        if (PlayerPrefs.GetInt("4.2.choose" + userId) == 1)
        {
            str = "一個";
        }
        else if (PlayerPrefs.GetInt("4.2.choose" + userId) == 2)
        {
            str = "兩個";
        }
        else if (PlayerPrefs.GetInt("4.2.choose" + userId) == 3)
        {
            str = "三個";
        }
        else if (PlayerPrefs.GetInt("4.2.choose" + userId) == 4)
        {
            str = "四個";
        }

        someText[22].text = str;

        if (PlayerPrefs.GetInt("4.3.choose" + userId) == 1)
        {
            str = "願意";
        }
        else if (PlayerPrefs.GetInt("4.3.choose" + userId) == 2)
        {
            str = "不願意";
        }


        someText[23].text = str;

        //5 sec
        if (PlayerPrefs.GetInt("5.1.choose" + userId) == 1)
        {
            str = "一手";
        }
        else if (PlayerPrefs.GetInt("5.1.choose" + userId) == 2)
        {
            str = "二手";
        }
        someText[24].text = str;
        someText[25].text = PlayerPrefs.GetInt("5.easyTime" + userId).ToString();


        someText[26].text = PlayerPrefs.GetInt("5.normalTime" + userId).ToString();
        someText[27].text = PlayerPrefs.GetInt("5.hardTime" + userId).ToString();


        someText[28].text = PlayerPrefs.GetInt("5.3.choose" + userId).ToString() + "G";
        someText[29].text = PlayerPrefs.GetInt("5.3.bedchoose" + userId).ToString() + "B";

        //6 sec
        someText[30].text = PlayerPrefs.GetInt("6.easyTime" + userId).ToString();
        someText[31].text = PlayerPrefs.GetInt("6.normalTime" + userId).ToString();
        someText[32].text = PlayerPrefs.GetInt("6.hardTime" + userId).ToString();

        someText[33].text = PlayerPrefs.GetInt("star" + userId).ToString();
        someText[34].text = PlayerPrefs.GetInt("star2" + userId).ToString();
    }
}
