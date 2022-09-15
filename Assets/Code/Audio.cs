using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    
    public static Audio instance = null;
    static string currentScene = "Level 1"; 
    string prevScene;
    

    void Awake()
    {
        print(instance != null);
        print(instance != this);
        print("supposed");
        
        print(currentScene);
        // found the code for keeping audio going here https://answers.unity.com/questions/783631/keep-audio-playing-even-though-i-reset-the-scene.html
        if (instance != null && instance != this && SceneManager.GetActiveScene().name == currentScene)
        {
          
            Destroy(gameObject);
            print("lol");
        
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
            print("hi");
        }
        currentScene = SceneManager.GetActiveScene().name;
        prevScene = currentScene;
        
    }

    void Update() {

        if(prevScene != currentScene){
            print("whoops");
            Destroy(gameObject);        
        }
        
        

    }

}
