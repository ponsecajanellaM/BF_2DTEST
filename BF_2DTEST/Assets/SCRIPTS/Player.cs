using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;

    public float gravity = -1f; //set player gravity force
    public float strength = 5f;  //weight of the player
    public float speed = 3;
   
    private SpriteRenderer spriteRenderer;
    
    //GET SPRITE ANIMATION
    public Sprite[] sprites;
    private int spriteIndex;


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite),0.15f, 0.15f );
    }

    private void AnimateSprite()
    {
        spriteIndex++;
        if(spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
    }










    private void Update()
    {
        //PLAYER CONTROLLER
        if (Input.GetKey(KeyCode.W)) //player going upwards
        {
            direction = Vector3.up * strength;
        }
        if (Input.GetKey(KeyCode.A)) //left sideway
        {
            direction = Vector3.left * strength;
        }
        if (Input.GetKey(KeyCode.D)) //right sideway
        {
            direction = Vector3.right * strength;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction = Vector3.down * strength;
        }

        direction.y += gravity * Time.deltaTime;
        direction.x += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

        
        //FLIP PLAYER
        Vector3 playerScaleX = transform.localScale;
        if (Input.GetAxis("Horizontal") > 0)
        {
            playerScaleX.x = 1;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            playerScaleX.x = -1;
        }

        transform.localScale = playerScaleX;

        //PLAYER BOUNDARY
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2f, 2f),
            Mathf.Clamp(transform.position.y, -1f, 1f), transform.position.z);




    }
}
