using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{
    public static int Score;
    public static int highScore;

    public static string scoreString;

    public Text scoretext;
    public Text highscoretext;

    public float scoreCount;  //new
    public float hiScoreCount; //new

    public bool scoreIncreasing; //new


    public GameManager theGM;
    public FreezeObjects theFreezeObj;
 
    public void AddScore()
    {
        Score++;
    }

    private void Start()
    {

        highScore = PlayerPrefs.GetInt("Highscore");

    }

    private void Update()
    {
        //HIGHSCORE COUNTER
        scoretext.text =  Score.ToString();
        highscoretext.text = highScore.ToString();
 
        if(Score > highScore)
        {
            PlayerPrefs.SetInt("Highscore", Score);
        }

        //HIT STOP SCENE FREEZE
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    Time.timeScale = 0f;

        //}

        //if (Input.GetKeyDown(KeyCode.E))
        //{

        //    Time.timeScale = 1f;
        //}

        SetCountText();
    }

    public void SetCountText()
    {
        if (Score >= 1000 && SceneMan.instance.Level == 1) //stop scene from looping
        {

            print("test " + SceneMan.instance.Level);

            SceneMan.instance.Level = 2; //stop scene from looping

            StartCoroutine(NextScene2());


            theGM.Victory();
            
            theFreezeObj.PauseAndResume();
        }

        if (Score >= 2000 && SceneMan.instance.Level == 2)
        {
            print("test " + SceneMan.instance.Level);
            
            SceneMan.instance.Level = 3;
            
            StartCoroutine(NextScene3());
            
            theGM.Victory();

            theFreezeObj.PauseAndResume();

        }

        //if (Score >= 3600 && SceneMan.instance.Level == 3)
        //{
        //    print("test " + SceneMan.instance.Level);

        //    SceneMan.instance.Level = 4;

        //    StartCoroutine(NextScene4());

        //    theFreezeObj.PauseAndResume();

        //    theGM.Victory();
        //}

        if (Score >= 3600 && SceneMan.instance.Level == 3)
        {
            print("test " + SceneMan.instance.Level);

            SceneMan.instance.Level = 4;

            StartCoroutine(NextScene5());

            theGM.Victory();

            theFreezeObj.PauseAndResume();

        }

        if (Score >= 4600 && SceneMan.instance.Level == 4)
        {
            SceneMan.instance.Level = 5;
            
            StartCoroutine(NextScene6());

            theGM.Victory();

            theFreezeObj.PauseAndResume();

        }

        //if (Score >= 5600 && SceneMan.instance.Level == 6)
        //{
        //    SceneMan.instance.Level = 7;

        //    StartCoroutine(NextScene7());
            
        //    theGM.Victory();

        //    theFreezeObj.PauseAndResume();

        //}

        if (Score >= 5600 && SceneMan.instance.Level == 5)
        {
            SceneMan.instance.Level = 6;

            StartCoroutine(NextSceneMainMenu());

            
            //theGM.Victory();

            //theFreezeObj.PauseAndResume();

        }

        //if (Score >= 6600 && SceneMan.instance.Level == 6)
        //{
        //    SceneMan.instance.Level = 9;

        //    StartCoroutine(NextScene9());

        //    theGM.Victory();

        //    theFreezeObj.PauseAndResume();


        //}

        //if (Score >= 7600 && SceneMan.instance.Level == 7)
        //{

        //    SceneMan.instance.Level = 10;

        //    StartCoroutine(NextScene10());

        //    theGM.Victory();

        //    theFreezeObj.PauseAndResume();

        //}

        //if (Score >= 9600 && SceneMan.instance.Level == 8)
        //{

        //    //SceneMan.instance.Level = 10;

        //    StartCoroutine(NextScene11());

        //    //theGM.Victory();

        //    //PauseAndResume();

        //}


    }

    IEnumerator NextScene2()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("Game2");
    }
    IEnumerator NextScene3()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Game3");
    }
    IEnumerator NextScene4()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Game4");
    }
    IEnumerator NextScene5()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Game5");
    }
    IEnumerator NextScene6()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Game6");
    }
    IEnumerator NextScene7()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Game7");
    }
    IEnumerator NextScene8()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Game8");
    }
    IEnumerator NextScene9()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Game9");
    }
    IEnumerator NextScene10()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Game10");
    }
    IEnumerator NextScene11()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("ScorePanel");
    }
    IEnumerator NextSceneMainMenu()
    {
        yield return new WaitForSeconds(0f);
        SceneManager.LoadScene("MainMenu");
    }

}
