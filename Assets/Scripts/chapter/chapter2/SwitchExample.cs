using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchExample : MonoBehaviour
{
    // START IS CALLED BEFORE THE FIRST FRAME UPDATE
    void start()
    {
        int a = 1;
        switch (a < 5)
        {
            case true:
                Debug.Log(a);
                break;

            case false:
                Debug.Log("a가 5보다 큽니다");
                break;
        }
    }
}
