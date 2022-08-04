using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WRAPR : MonoBehaviour
{
    private void OnTriggerEnter(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.position = new Vector3(-4372f, other.gameObject.transform.position.y, -1537f);
        }
        //if (other.tag == "Enemy")
        //{
        //    other.gameObject.transform.position = new Vector3(-4, other.gameObject.transform.position.y, -0.4f);
        //}
    }
}
