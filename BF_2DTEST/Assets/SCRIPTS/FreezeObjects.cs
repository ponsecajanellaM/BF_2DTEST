using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FreezeObjects : MonoBehaviour
{
    public TestingController thePlayer;

    public EnemyTestAI theEnemy1;
    public EnemyTestAI theEnemy2;
    public EnemyTestAI theEnemy3;
    public EnemyTestAI theEnemy4;
    public EnemyTestAI theEnemy5;

    public RandomWander theBubbles1;
    public RandomWander theBubbles2;
    public Spawner theBubblesSpawner1;
    public Spawner theBubblesSpawner2;
    
    public RandomWander theBolt1;
    public RandomWander theBolt2;
    public RandomWander theBolt3;
    public Spawner theBoltSpawner1;
    public Spawner theBoltSpawner2;
    public Spawner theBoltSpawner3;


    public void PauseAndResume()// make screen freeze with timer
    {
        StartCoroutine(ResumeAfterNSeconds(1.0f));
    }


    public IEnumerator ResumeAfterNSeconds(float timePeriod) // make screen freeze with timer
    {
        //Player STOP
        thePlayer.GetComponent<TestingController>().controlActive = false;
        thePlayer.animator.enabled = false;
        thePlayer.rb.isKinematic = true;

        //BLUE BUBBLES STOP
        theBubbles1.gameObject.GetComponent<RandomWander>().enabled = false;
        theBubblesSpawner1.gameObject.GetComponent<Spawner>().enabled = false;

        theBubbles2.gameObject.GetComponent<RandomWander>().enabled = false;
        theBubblesSpawner2.gameObject.GetComponent<Spawner>().enabled = false;

        //BOLT STOP
        theBolt1.gameObject.GetComponent<RandomWander>().enabled = false;
        theBoltSpawner1.gameObject.GetComponent<Spawner>().enabled = false;

        //theBolt2.gameObject.GetComponent<RandomWander>().enabled = false;
        //theBoltSpawner2.gameObject.GetComponent<Spawner>().enabled = false;

        //theBolt3.gameObject.GetComponent<RandomWander>().enabled = false;
        //theBoltSpawner3.gameObject.GetComponent<Spawner>().enabled = false;

        //ENEMY STOP
        theEnemy1.GetComponent<EnemyTestAI>().isWalking = false;
        theEnemy1.myRigidbody.isKinematic = true;
        theEnemy1.gameObject.GetComponent<Animator>().enabled = false; //stop the animation

        theEnemy2.GetComponent<EnemyTestAI>().isWalking = false;
        theEnemy2.myRigidbody.isKinematic = true;
        theEnemy2.gameObject.GetComponent<Animator>().enabled = false; //stop the animation

        theEnemy3.GetComponent<EnemyTestAI>().isWalking = false;
        theEnemy3.myRigidbody.isKinematic = true;
        theEnemy3.gameObject.GetComponent<Animator>().enabled = false; //stop the animation

        theEnemy4.GetComponent<EnemyTestAI>().isWalking = false;
        theEnemy4.myRigidbody.isKinematic = true;
        theEnemy4.gameObject.GetComponent<Animator>().enabled = false; //stop the animation

        theEnemy5.GetComponent<EnemyTestAI>().isWalking = false;
        theEnemy5.myRigidbody.isKinematic = true;
        theEnemy5.gameObject.GetComponent<Animator>().enabled = false; //stop the animation

        yield return new WaitForSeconds(timePeriod);


    }
}
