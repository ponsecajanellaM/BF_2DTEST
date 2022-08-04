using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreCOUNTER : MonoBehaviour
{
    public Text highscoreText;
    public int highscore = 0;
    public static int pointAmount;

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        //pointText = GetComponent<Text>();
        highscoreText.text = "HIGHSCORE" + pointAmount.ToString();
        highscoreText = GetComponent<Text>();
    }
    public void AddPoint()
    {
        if (highscore < pointAmount)
            PlayerPrefs.SetInt("highscore", pointAmount);
        

    }
}
    