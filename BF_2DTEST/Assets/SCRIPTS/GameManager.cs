using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TestingController thePlayer;
    public EnemyTestAI theEnemy;

    //private Vector2 playerStart;
    public Transform respawnPoint;

    public GameObject victoryScreen;
    public GameObject gameOverScreen;
    public string MainMenu;
    public string NextLevel;

    private BallonTripScore theBallonTrip;

    void Start()
    {
        //playerStart = transform.position;

        theBallonTrip = FindObjectOfType<BallonTripScore>();
    }
   
    public void Victory()
    {
        //victoryScreen.SetActive(true); 
        //thePlayer.gameObject.SetActive(false);// player disapper when victory pops out
        StartCoroutine("VictoryNextGame");
     
    }
   
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        thePlayer.gameObject.SetActive(false);// player disapper when victory pops out

        //theBallonTrip.scoreIncreasing = false; // balloon trip code 

        StartCoroutine("GameReset"); // reset score when reset and game over
        
        //LivesManager1.PlayerLives = 0; //3
        
        ScoreManager.Score = 0;

        //theBallonTrip.scoreCount = 0; // balloon trip code 
        //theBallonTrip.scoreIncreasing = true; // balloon trip code 
    }

    public void ResetMenu()
    {
        SceneManager.LoadScene(MainMenu);
    }
    public void QUIT()
    {
        Application.Quit();
        Debug.Log("test");
    }
    IEnumerator GameReset()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(MainMenu);

        theBallonTrip.scoreIncreasing = false; // balloon trip code 
        
        //theBallonTrip.scoreCount = 0; // balloon trip code 
       
        theBallonTrip.scoreIncreasing = true; // balloon trip code 
    }

    IEnumerator VictoryNextGame()
    {
        yield return new WaitForSeconds(5f);
        
        victoryScreen.SetActive(true);
        thePlayer.gameObject.SetActive(false);
        theEnemy.gameObject.SetActive(false);

        //SceneManager.LoadScene(NextLevel);
    }

    public void Reset()
    {
        //ScoreManager.Score = 0;// reset score when reset and game over
        victoryScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        thePlayer.gameObject.SetActive(true);
        thePlayer.transform.position = respawnPoint.position;
  
    }
}
