using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WRAPL : MonoBehaviour
{
    private void OnTriggerEnter(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.position = new Vector3(3268, other.gameObject.transform.position.y, -1537f);
        }
        //if (other.tag == "Enemy")
        //{
        //    other.gameObject.transform.position = new Vector3(16f, other.gameObject.transform.position.y, -0.4f);
        //}
    }
}
