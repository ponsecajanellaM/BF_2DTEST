using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WRAPR : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.position = new Vector3(-7, other.gameObject.transform.position.y, -0.7f);
        }
        if (other.tag == "Enemy")
        {
            other.gameObject.transform.position = new Vector3(-4, other.gameObject.transform.position.y, -0.4f);
        }
    }
}
