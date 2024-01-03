using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int item in numbers)
        {
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
