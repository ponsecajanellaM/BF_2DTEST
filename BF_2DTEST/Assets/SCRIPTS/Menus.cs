using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{

    public string LevelToLoad;
  public void Replay()
    {
        FindObjectOfType<GameManager>().Reset();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
    public void PlayBT()
    {
        SceneManager.LoadScene("BalloonTRIP");
    }
}
