using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForExample : MonoBehaviour
{
    int a;
    // Start is called before the first frame update
    void Start()
    {
        //for(int j = 1; j < 6; j++) 
        //{ 
        //    Debug.Log(j);
        //}
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                a += i;
            }
        }
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
