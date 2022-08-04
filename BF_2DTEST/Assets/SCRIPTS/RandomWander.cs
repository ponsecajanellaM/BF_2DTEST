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
 
    void FixedUpdate()
    {
        Vector3 a = transform.position;
        Vector3 b = tar.position;
        transform.position = Vector3.Lerp(a, b, t);
    }
 
}
