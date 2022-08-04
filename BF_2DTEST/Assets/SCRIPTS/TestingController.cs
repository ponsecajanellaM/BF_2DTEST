using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestingController : MonoBehaviour
{
    public float speed = 2f;

    public Rigidbody rb;
    public float flyStrength = 1;

    public float gravityScale = 0.1f;

    public Animator animator;
    
   
   public bool controlActive;
    private bool isPlayerDead;

    private Collider playercol;
   public GameObject[] childobjs;
    

    public GameManager theGM;
    private LivesManager theLM;

    //public float point = 300;

    //public TextMeshProUGUI textPoints;

    private void Start()
    {
       


        theLM = FindObjectOfType<LivesManager>();

        //currentHP = playerHP;
        playercol = GetComponent<Collider>(); //disable collider in the inspector

        controlActive = true;
    }


    void FixedUpdate()
    {
        


        if (controlActive == true)
        {
            animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

            rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);

            Vector2 pos = transform.position;

            if (Input.GetKeyDown(KeyCode.W))
            {
                //pos.y += speed * Time.deltaTime;
                rb.AddForce(Vector2.up * flyStrength, ForceMode.Impulse);
            }

            if (Input.GetKey("d"))
            {
                pos.x += speed * Time.deltaTime;
            }
            if (Input.GetKey("a"))
            {
                pos.x -= speed * Time.deltaTime;
            }


            Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position = transform.position + horizontal;
            transform.position = pos;
        }

        
    }




    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Spike")
        {
            if (LivesManager1.PlayerLives == 0)
            {
                PlayerDeath();
            }
            else
            {
                theLM.TakeLife();
                theGM.Reset();
            }
                //PlayerDeath();
            //theGM.GameOver();
            //theLM.TakeLife();
            //theGM.Reset(); no respawn
        }

        
        void PlayerDeath()
        {
            //if(LivesManager1.PlayerLives == 0)
            //{
            //    isPlayerDead = true;
            //    animator.SetBool("PlayerDead", isPlayerDead);
            //    controlActive = false;
            //    playercol.enabled = false;
            //}

            isPlayerDead = true;
            animator.SetBool("PlayerDead", isPlayerDead);

            controlActive = false;
            playercol.enabled = false;

            foreach (GameObject child in childobjs)
                child.SetActive(false);
            
           StartCoroutine("PlayerRespawn");

        }

        //if (collision.gameObject.CompareTag("Points")) //collect points
        //{
        //    textPoints.text = point.ToString();
        //    point ++;
        //    Destroy(collision.gameObject);

        //}




    }
    IEnumerable PlayerRespawn()
    {
        yield return new WaitForSeconds(1.5f);

        isPlayerDead = false;
        animator.SetBool("PlayerDead", isPlayerDead);


        playercol.enabled = true;

        foreach (GameObject child in childobjs)
            child.SetActive(true);

        yield return new WaitForSeconds(0.1f);

        controlActive = true;
    }

    

}

