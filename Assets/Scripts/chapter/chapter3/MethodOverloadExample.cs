using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverloadExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Add(1,2));
        Debug.Log(Add(1.1f, 2.1f));
        Debug.Log(Add(2.0d, 3.1d));
    }

    int Add(int a, int b)
    {
        return a + b;
    }
    float Add(float a, float b)
    {
        return a + b;
    }
    double Add(double a, double b)
    {
        return a + b;
    }
}
