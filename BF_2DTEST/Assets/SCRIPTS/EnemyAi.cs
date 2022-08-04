using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public float speed;
    public float range;
    public float maxDistance;

    Vector2 wayPoint;

    //private SpriteRenderer spriteRenderer;

    ////GET SPRITE ANIMATION
    //public Sprite[] sprites;
    //private int spriteIndex;


    //float PointY;
    //int direction = 1;

    //private void Awake()
    //{
    //    spriteRenderer = GetComponent<SpriteRenderer>();
    //}

    void Start()
    {
        //PointY = transform.position.y; // position of the enemy

        SetNewDistanation();
        //InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);


    }
    //private void AnimateSprite()
    //{
    //    spriteIndex++;
    //    if (spriteIndex >= sprites.Length)
    //    {
    //        spriteIndex = 0;
    //    }
    //    spriteRenderer.sprite = sprites[spriteIndex];
    //}


    void FixedUpdate() //smooth movement
    {
        //transform.Translate(Vector2.up * speed * Time.deltaTime * direction);

        //if (transform.position.y < PointY || transform.position.y > PointY + range)
        //    direction *= -1;


        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position,wayPoint) < range)
        {
            SetNewDistanation();

        }



        ////FLIP PLAYER
        //Vector3 playerScaleX = transform.localScale;
        //if (Input.GetAxis("Horizontal") > 0)
        //{
        //    playerScaleX.x = 1;
        //}
        //if (Input.GetAxis("Horizontal") < 0)
        //{
        //    playerScaleX.x = -1;
        //}

        //transform.localScale = playerScaleX;
    }

    void SetNewDistanation()
    {
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }




}
