using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class ILE4Plugin : MonoBehaviour
{
    [DllImport("ILE 4 FIXED")]

    private static extern int AddTwoIntegers(int i1, int i2);

    [DllImport("ILE 4 FIXED")]

    private static extern int SubtractTwoIntegers(int i1, int i2);

    [DllImport("ILE 4 FIXED")]

    private static extern int DivideTwoIntegers(int i1, int i2);

    [DllImport("ILE 4 FIXED")]

    private static extern int MultiplyTwoIntegers(int i1, int i2);


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(AddTwoIntegers(15, 10));
        Debug.Log(SubtractTwoIntegers(8, 4));
        Debug.Log(DivideTwoIntegers(25, 5));
        Debug.Log(MultiplyTwoIntegers(5, 5));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
