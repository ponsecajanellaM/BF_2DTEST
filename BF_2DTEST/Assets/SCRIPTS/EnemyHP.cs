using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int enemyHP;
    private int currentHP;
    private Animator Anim;

    private bool isEnemyDead;

    private Collider parentCol;
    private Collider hitboxCol;

    private EnemyTestAI enemyscript;
    void Start()
    {
        currentHP = enemyHP;

        Anim = transform.parent.GetComponent<Animator>();

        parentCol = transform.parent.GetComponent<Collider>();
        hitboxCol = GetComponent<Collider>();

        enemyscript = transform.parent.GetComponent<EnemyTestAI>();
    }

    
    void Update()
    {
        if(currentHP <= 0 )
        {

            isEnemyDead = true;
            Anim.SetBool("EnemyDead", isEnemyDead);

            parentCol.enabled = false; // disable component without destorying it
            hitboxCol.enabled = false;
            enemyscript.enabled = false;

            //destory moving script and turn off box collider then enemy will fall
            //Destroy(transform.parent.GetComponent<EnemyTestAI>());
            //Destroy(transform.parent.GetComponent<BoxCollider >());
            //gameObject.GetComponent<BoxCollider>().isTrigger = true;




        }

    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
    }

    
}
