using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StomperTest : MonoBehaviour
{
    public int damageToDeal;
    private Rigidbody rb;
    public float bounceForce;

    void Start()
    {
        rb = transform.parent.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "HitBox")
        {
            other.gameObject.GetComponent<EnemyHP>().TakeDamage(damageToDeal);

            rb.AddForce(transform.up * bounceForce, ForceMode.Impulse);
        }
    }
}
