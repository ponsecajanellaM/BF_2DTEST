using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
 
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Physics2D.gravity = new Vector2(0, 9.8f);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            Physics2D.gravity = new Vector2(0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Physics2D.gravity = new Vector2(0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Physics2D.gravity = new Vector2(0, 0);
        }
    }
}
