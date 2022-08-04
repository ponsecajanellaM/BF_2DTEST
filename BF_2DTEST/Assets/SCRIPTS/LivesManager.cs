using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    //public int defaultLives;
    //public int liveCounter;

    public Text livesText;

    private GameManager theGM;
    
    
    
    void Start()
    {
        //liveCounter = defaultLives;

        theGM = FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        livesText.text = "x " + LivesManager1.PlayerLives;

        if(LivesManager1.PlayerLives == 0)
        {
            theGM.GameOver();
        }
    }

    public void TakeLife()
    {
        LivesManager1.PlayerLives--;
    }
    public void AddLife()
    {
        LivesManager1.PlayerLives++;
    }
}
