using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITEST : MonoBehaviour
{
    public float speed;
    public float range;
    public float gravity;
    public float maxDistance;

    Vector3 wayPoint;



    // Start is called before the first frame update
    void Start()
    {
        SetNewDistanation();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, wayPoint) < range)
        {
            SetNewDistanation();

        }
    }
    void SetNewDistanation()
    {
        wayPoint = new Vector3(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }
}
