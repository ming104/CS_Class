using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ExampleClass.number = 1;

        ExampleClass.Hello();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class ExampleClass
{
    public static int number;

    public static void Hello()
    {
        Debug.Log("number");
    }
}
