using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    //Functions used to switch between scenes. Scenemanager loads the scene and a new instance is created using the 'SingletonManager' object 'Instance'
    public void LoadFirstScene()
    {
       //Load the first scene
        SceneManager.LoadScene("Scene 1");
        SingletonManager.Instance.value++;

    }

    public void LoadSecondScene()
    {
        //Load the first scene
        SceneManager.LoadScene("Scene 2");
        SingletonManager.Instance.value++;

    }

    
}
