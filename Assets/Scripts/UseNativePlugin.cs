using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class UseNativePlugin : MonoBehaviour
{
    [DllImport("Native Plugin")]
    private static extern int PrintANumber();

    [DllImport("Native Plugin")]
    private static extern int AddTwoIntegers(int i1, int i2);

    [DllImport("Native Plugin")]
    private static extern float AddTwoFloats(float f1, float f2);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PrintANumber());
        Debug.Log(AddTwoIntegers(2, 2));
        Debug.Log(AddTwoFloats(2.5f, 4f));


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
