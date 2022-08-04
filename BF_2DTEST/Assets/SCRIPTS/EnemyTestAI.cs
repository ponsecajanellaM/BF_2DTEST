using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTestAI : MonoBehaviour
{
    //public float speed;
    //public float range;
    //public float maxDistance;

    //Vector3 wayPoint;
    //void Start()
    //{
    //    SetNewDestination();
    //}


    //void Update()
    //{
    //    transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
    //    if(Vector2.Distance(transform.position, wayPoint)< range)
    //    {
    //        SetNewDestination();
    //    }
    //}

    //void SetNewDestination()
    //{
    //    wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    //}


    //public GameObject enemyPrefab;
    //private float speed = 5.0f;
    //public float width = 10f;
    //public float height = 5f;
    //private bool movingRight = true;
    //private bool movingDown = true;
    //private float xmax;
    //private float xmin;
    //private float ymax;
    //private float ymin;



    //// Use this for initialization
    //void Start()
    //{
    //    foreach (Transform child in transform)
    //    {
    //        GameObject enemy = Instantiate(enemyPrefab, child.transform.position, Quaternion.identity) as GameObject;
    //        enemy.transform.parent = child;
    //    }
    //    //calc distance object is to camera, only needed for 3d.
    //    float distanceToCamera = transform.position.z - Camera.main.transform.position.z;

    //    //find x and y coordinates of object
    //    var leftBoundary = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceToCamera)).x;
    //    var rightEdge = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distanceToCamera)).x;
    //    var bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceToCamera)).y;
    //    var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distanceToCamera)).y;
    //    xmax = rightEdge;
    //    xmin = leftBoundary;
    //    ymax = topBorder;
    //    ymin = bottomBorder;



    //}

    //public void OnDrawGizmos()
    //{
    //    Gizmos.DrawWireCube(transform.position, new Vector3(width, height));

    //}


    //// Update is called once per frame
    //void Update()
    //{
    //    if (movingRight)
    //    {
    //        transform.position += new Vector3(Random.Range(1, 5), 0, 0) * speed * Time.deltaTime;
    //    }
    //    else
    //    {
    //        transform.position += new Vector3(Random.Range(-1, -5), 0, 0) * speed * Time.deltaTime;
    //    }
    //    if (movingDown)
    //    {
    //        transform.position += new Vector3(0, Random.Range(-1, -5), 0) * speed * Time.deltaTime;
    //    }
    //    else
    //    {
    //        transform.position += new Vector3(0, Random.Range(1, 5), 0) * speed * Time.deltaTime;
    //    }

    //    // Check if the formation is going outside the playspace...
    //    float rightEdgeOfFormation = transform.position.x + (0.5f * width);
    //    float leftEdgeOfFormation = transform.position.x - (0.5f * width);
    //    float topEdgeOfFormation = transform.position.y + (0.5f * height);
    //    float bottomEdgeOfFormation = transform.position.y - (0.5f * height);
    //    if (leftEdgeOfFormation < xmin || rightEdgeOfFormation > xmax)
    //    {
    //        movingRight = !movingRight;
    //    }
    //    if (bottomEdgeOfFormation < ymin || topEdgeOfFormation > ymax)
    //    {
    //        movingDown = !movingDown;
    //    }


    //}



    //    public float offset;
    //    public float radius;
    //    public float rate;
    //public Vector3 GetOriAsVec(float orientation)
    //{
    //    Vector3 vector = Vector3.zero;
    //    vector.x = Mathf.Sin(orientation * Mathf.Deg2Rad) * 1.0f;
    //    vector.z = Mathf.Cos(orientation * Mathf.Deg2Rad) * 1.0f;
    //    return vector.normalized;
    //}
    //public override void Awake()
    //{
    //    target = new GameObject();
    //    target.transform.position = transform.position;
    //    base.Awake();
    //}

    //public override Steering GetSteering()
    //{
    //    Steering steering = new Steering();
    //    float wanderOrientation = Random.Range(-1.0f, 1.0f) * rate;
    //    float targetOrientation = wanderOrientation + agent.orientation;
    //    Vector3 orientationVec = OriToVec(agent.orientation);
    //    Vector3 targetPosition = (offset * orientationVec) + transform.position;
    //    targetPosition = targetPosition + (OriToVec(targetOrientation) * radius);
    //    targetAux.transform.position = targetPosition;
    //    steering = base.GetSteering();
    //    steering.linear = targetAux.transform.position - transform.position;
    //    steering.linear.Normalize();
    //    steering.linear *= agent.maxAccel;
    //    return steering;
    //}

    public float moveSpeed;
    public Rigidbody myRigidbody;

    public bool isWalking;

    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;

   public float walkDirection;

    public ScoreManager theSM;
    public int Respawn;

    public GameObject player;
    public Transform respawnPoint;


    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        waitCounter = waitTime;
        walkCounter = waitTime;

        ChooseDirection();

    }
    private void Update()
    {
        if (isWalking == true)
        {
            walkCounter -= Time.deltaTime;

            
            switch (walkDirection)
            {
                case 0:

                    myRigidbody.velocity = new Vector2(0, moveSpeed);
                    break;

                case 1:
                    myRigidbody.velocity = new Vector2(moveSpeed, 0);
                    break;
                
                case 2:
                    myRigidbody.velocity = new Vector2(0, -moveSpeed);
                    break;
                    
                case 3:
                    myRigidbody.velocity = new Vector2(-moveSpeed, 0);
                    break;
            }

            if (walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }


        }
        else
        {
            waitCounter -= Time.deltaTime;
            myRigidbody.velocity = Vector2.zero;

            if(walkCounter < 0)
            {
                ChooseDirection();
            }


        }

       


        
    }

    
    //public void DisableKinectic()
    //{
    //    myRigidbody.isKinematic = true;
    //    myRigidbody.detectCollisions = false;
    //    theSM.SetCountText();
    //}

    public void ChooseDirection()
    {
        walkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;
    }

    //private void OnCollisionEnter(Collision other) //respawn player to any direction with the respawn point
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        player.transform.position = respawnPoint.position;
    //    }
    //}

    //private void OnTriggerEnter(Collider other) // reload scene
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        SceneManager.LoadScene(Respawn);
    //    }
    //}


}
