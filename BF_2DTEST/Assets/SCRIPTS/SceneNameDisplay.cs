using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneNameDisplay : MonoBehaviour
{

    void Start()
    {
        string Scenename = SceneManager.GetActiveScene().name;
        gameObject.GetComponent<Text>().text = "Level: " + Scenename;
    }


}
