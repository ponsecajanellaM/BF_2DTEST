using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{

    Text pointText;
    //public Text highscoreText;

    public static int pointAmount;
    //public int highscore = 0;

    void Start()
    {
        //highscore = PlayerPrefs.GetInt("highscore", 0);
        pointText = GetComponent<Text>();
        //highscoreText.text = "HIGHSCORE" + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = pointAmount.ToString();
        //highscoreText.text = "HIGHSCORE" + highscore.ToString();

    }

    //public void AddPoint()
    //{
    //   if(highscore < pointAmount)
    //    {
    //        PlayerPrefs.SetInt("highscore", pointAmount);
    //    }
        
    //}
}
