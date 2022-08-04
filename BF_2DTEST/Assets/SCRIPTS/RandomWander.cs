////using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWander : MonoBehaviour
{
    //public float speed;
    public float range;
    public float maxDistance;

    Vector3 wayPoint;
    public Vector3 target = new Vector3(1, 1, 0);
    private float speed = 1;

    public Transform tar;
    public float t;

    public float spd = 5;
    


    void Start()
    {
        //SetNewDestination();

        //transform.position = new Vector3(0, 2, 0);
    }

    
    void FixedUpdate()
    {
        //transform.position = Vector3.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        //if(Vector3.Distance(transform.position, wayPoint)< range)
        //{
        //    SetNewDestination();
        //}

        //transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);


        //lerp

        Vector3 a = transform.position;
        Vector3 b = tar.position;
        transform.position = Vector3.Lerp(a, b, t);




    }

    //void SetNewDestination()
    //{
    //    wayPoint = new Vector3(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    //}
}
