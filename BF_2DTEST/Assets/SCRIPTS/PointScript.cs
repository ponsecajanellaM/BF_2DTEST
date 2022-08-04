using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            ScoreManager.Score += 200;
            //ScoreManager.Score ++;
        }
    }
}
