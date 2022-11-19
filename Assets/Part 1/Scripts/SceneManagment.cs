using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagment : MonoBehaviour
{
    public static int people = 0;

    public static float timeUp = 0;

    private void Awake()
    {
        people = PlayerPrefs.GetInt("people");
        timeUp = 0;
        print(people);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.DeleteAll();
            print("Deleted");
        }

        timeUp += Time.deltaTime;

    }

   

    public void easy()
    {
        people += 1;
        PlayerPrefs.SetInt("people", people);
        SceneManager.LoadScene("1.Easy");
        
    }

    public void normal()
    {
        PlayerPrefs.SetInt("1.easy" + people, cardEasy.wrongCount);
        PlayerPrefs.SetInt("1.1.easy" + people, cardEasyPick.wrongCount);
        PlayerPrefs.SetInt("1.easyTime" + people, (int)time.timeRemaining);

        Invoke("n", 1);

    }

    void n()
    { SceneManager.LoadScene("1.Normal"); }

    public void hard()
    {
        PlayerPrefs.SetInt("1.normal" + people, cardNormal.wrongCount);
        PlayerPrefs.SetInt("1.1.normal" + people, cardNormalPick.wrongCount);
        PlayerPrefs.SetInt("1.normalTime" + people, (int)timeUp);
        Invoke("h", 1);

    }
    void h()
    { SceneManager.LoadScene("1.Puzzle"); }

    public void easy2()
    {
        PlayerPrefs.SetInt("1.hard" + people, cardHard.wrongCount);
        PlayerPrefs.SetInt("1.1.hard" + people, cardHardPick.wrongCount);
        PlayerPrefs.SetInt("1.hardTime" + people, (int)timeUp);

        Invoke("e2", 1);
    }
    void e2()
    { SceneManager.LoadScene("2.Easy"); }

    public void normal2()
    {
        PlayerPrefs.SetInt("2.easyTime" + people, (int)time.timeRemaining);
        SceneManager.LoadScene("2.Normal");

       
    }

    public void hard2()
    {
        PlayerPrefs.SetInt("2.normalTime" + people, (int)timeUp);
        SceneManager.LoadScene("2.Puzzle");
       
    }

    public void easy3()
    {
        PlayerPrefs.SetInt("2.hardTime" + people, (int)timeUp);
        SceneManager.LoadScene("3.Easy");
       

    }

    public void normal3()
    {
        PlayerPrefs.SetInt("3.easy" + people, Game_Easy.wrongCount);
        PlayerPrefs.SetInt("3.easyTime" + people, (int)time.timeRemaining);
        SceneManager.LoadScene("3.Normal");

     
    }

    public void hard3()
    {
        PlayerPrefs.SetInt("3.normal" + people, Game_Normal.wrongCount);
        PlayerPrefs.SetInt("3.normalTime" + people, (int)timeUp);
        SceneManager.LoadScene("3.Puzzle");
       
    }

    public void easy4()
    {
        PlayerPrefs.SetInt("3.hard" + people, Game_Hard.wrongCount);
        PlayerPrefs.SetInt("3.hardTime" + people, (int)timeUp);

        SceneManager.LoadScene("4.Easy");
     
    }



    public void normal4()
    {
        SceneManager.LoadScene("4.Normal");


        PlayerPrefs.SetInt("4.easyTime" + people, (int)time.timeRemaining);
        PlayerPrefs.SetInt("4.1.choose" + people, family.choose);

    }

    public void hard4()
    {
        SceneManager.LoadScene("4.Puzzle");
        PlayerPrefs.SetInt("4.normalTime" + people, (int)timeUp);
        PlayerPrefs.SetInt("4.2.choose" + people, family.choose);
    }

    public void easy5()
    {
        SceneManager.LoadScene("5.Easy");
        PlayerPrefs.SetInt("4.hardTime" + people, (int)timeUp);
        PlayerPrefs.SetInt("4.3.choose" + people, family.choose);

    }

    public void normal5()
    {
        SceneManager.LoadScene("5.Normal");
        PlayerPrefs.SetInt("5.easyTime" + people, (int)timeUp);
        PlayerPrefs.SetInt("5.1.choose" + people, family.choose);
    }

    public void hard5()
    {
        SceneManager.LoadScene("5.Puzzle");
        PlayerPrefs.SetInt("5.trash" + people, DragNormal.i);
        PlayerPrefs.SetInt("5.normalTime" + people, (int)timeUp);

    }

    public void easy6()
    {
        SceneManager.LoadScene("6.Easy");
        PlayerPrefs.SetInt("5.3.choose" + people, foodClick.count);
        PlayerPrefs.SetInt("5.3.bedchoose" + people, foodClick.badCount);
        PlayerPrefs.SetInt("5.hardTime" + people, (int)timeUp);

    }

    public void normal6()
    {
        SceneManager.LoadScene("6.Normal");
        PlayerPrefs.SetInt("6.easyTime" + people, (int)time.timeRemaining);
    }

    public void hard6()
    {
        SceneManager.LoadScene("6.Puzzle");
        PlayerPrefs.SetInt("6.normalTime" + people, (int)timeUp);

    }

    public void final()
    {
        SceneManager.LoadScene("final start");
        PlayerPrefs.SetInt("6.hardTime" + people, (int)timeUp);

    }

    public void home()
    {
        SceneManager.LoadScene("Home");
        PlayerPrefs.SetInt("star" + people, star.star111);
        PlayerPrefs.SetInt("star2" + people, star.star222);
    }


    public void backend()
    {
        SceneManager.LoadScene("BackEnd");
       
    }

    public void backend2()
    {
        SceneManager.LoadScene("Backend 2");

    }

    public void show() { 
    
    
    }
}
