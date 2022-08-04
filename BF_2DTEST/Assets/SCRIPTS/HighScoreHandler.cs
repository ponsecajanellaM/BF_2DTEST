using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreHandler : MonoBehaviour
{
    List<HighScoreElement> highscoreList = new List<HighScoreElement>();
    [SerializeField] int maxCount = 7;
    [SerializeField] string filename;

    private void Start()
    {
        LoadHighscore();
    }
    private void LoadHighscore()
    {
        highscoreList = FileHandler.ReadListFromJSON<HighScoreElement>(filename);

       while(highscoreList.Count > maxCount)
        {
            highscoreList.RemoveAt(maxCount);
        }
    }
    private void SaveHighscore()
    {
        FileHandler.SaveToJSON<HighScoreElement>(highscoreList, filename);
    }
    public void AddHighscoreIfPossible(HighScoreElement element)
    {
        for(int i = 0; i < maxCount; i ++)
        {
            if(i > highscoreList.Count || element.points > highscoreList[i].points)
            {
                //add new high score
                highscoreList.Insert(i, element);
                
                while (highscoreList.Count > maxCount)
                {
                    highscoreList.RemoveAt(maxCount);
                }
                
                SaveHighscore();
                break;
            }
        }
    }
}
