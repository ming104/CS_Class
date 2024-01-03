using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaExample : MonoBehaviour
{
    delegate int myDelegate(int a, int b);

    // Start is called before the first frame update
    void Start()
    {
        myDelegate del = (a, b) => a + b;
        Debug.Log(del(1,3));
    }
}
