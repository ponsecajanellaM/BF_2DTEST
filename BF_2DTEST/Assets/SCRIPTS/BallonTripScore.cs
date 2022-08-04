using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallonTripScore : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;
    
    
    public float scoreCount;  //new
    public float hiScoreCount; //new

    public float pointPerSeconds;
    
    public bool scoreIncreasing; //new

    private void Start()
    {
        
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        


        //hiScoreCount = PlayerPrefs.GetFloat("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreIncreasing)
        {
            scoreCount += pointPerSeconds * Time.deltaTime;
        }

        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;

            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
        }

        scoreText.text = "" + Mathf.Round(scoreCount);
          
        hiScoreText.text = "" + Mathf.Round(hiScoreCount); //Mathf.Round (whole number display)
    }
}
