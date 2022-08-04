using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objToSpawn;

    public float timeLeft, originalTime;


    void Start()
    {
        
    }

    
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if(timeLeft <= 0)
        {
            //spawn point
            Instantiate(objToSpawn, transform.position, Quaternion.identity);

            timeLeft = originalTime; //reset time
        }
    }
}
