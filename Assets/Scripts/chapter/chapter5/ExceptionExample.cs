using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExceptionExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arr = { 1, 2, 3 };
        int sum = 0;

        try
        {
            for (int i = 0; i < 5; i++)
            {
                sum += arr[i];
            }
        }

        catch(System.Exception e)
        {
            Debug.Log(e.Message);
        }

        finally
        {
            Debug.Log(sum);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
