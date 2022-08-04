using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreData : MonoBehaviour
{
    public List<ScoreManager> scores;

    public ScoreData()
    {
        scores = new List<ScoreManager>();
    }
}
