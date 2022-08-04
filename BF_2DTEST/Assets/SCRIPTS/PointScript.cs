using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //ointCounter.pointAmount += 200;
            //Destroy(gameObject);

            gameObject.SetActive(false);

            ScoreManager.Score += 200;

            //ScoreManager.Score ++;
        }
    }
}
