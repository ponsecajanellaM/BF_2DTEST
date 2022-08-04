using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    public float speed;
    public bool chase = false;
    public Transform startingPoint;

    //GET SPRITE ANIMATION
    public Sprite[] sprites;
    private int spriteIndex;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); //game start the animation cycle

    }

  

    private void AnimateSprite()
    {
        spriteIndex++;
        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //find the tag player in inspector
        
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f); // repeat cycle animation of sprite

    }

   
    void Update()
    {
        if (player == null) // if the enemy does not detect the player it will return to its original state
            return;
        if (chase == true)
            Chase();
        else
            ReturnStartPoint();

        Chase();

        //
        //FLIP SPRITE
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
    }
     private void Chase()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position,
         speed * Time.deltaTime);

    }

    private void ReturnStartPoint()
    {
        transform.position = Vector2.MoveTowards(transform.position, startingPoint.position,
                 speed * Time.deltaTime);
    }

}
