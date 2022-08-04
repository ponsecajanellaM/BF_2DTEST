using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{
    public static SceneMan instance;
    public int Level; 
    
    // Start is called before the first frame update
    void Start()
    {
        SceneMan.instance.Level = 1;
        //SceneMan.instance.Level = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        if (instance == null)
        {
   
            instance = this;
            DontDestroyOnLoad(instance);
        } 
        else
        {
            Destroy(this);
        }
    
    }
}

