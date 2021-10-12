using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonManager : MonoBehaviour
{
    //This code was referenced from Parisa's lab 4 video: https://drive.google.com/file/d/1mKuH4BzcJgqX2wQFOKWYbX6r7i3cS7mQ/view

    public static SingletonManager Instance {get; private set;}

    public int value;

    //Singleton Function, this function applies the singlton desing pattern
    //by determining if the instance of an object is created

    private void Awake()
    {
        //Singleton pattern: If their is no instance of an object, create one
        if(Instance == null)
        {
            
            //Set object equal to the this pointer which points to the object for which the method is called
            Instance = this;
            DontDestroyOnLoad(gameObject);


        }
        else
        {
            //If an instance of the object already exists, then it should be destroyed
            Destroy(gameObject);

        }
    }

}
