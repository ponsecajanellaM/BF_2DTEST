using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSysEnemy : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreManager.Score += 400;

            //Destroy(gameObject);
            gameObject.SetActive(false);
            
        }
    }
}
