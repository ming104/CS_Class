using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str8 = String.Format("4+8의 값은 {0}입니다.", 4 + 8);
        Debug.LogFormat("4+8은 {0}이고 6+12는 {1}입니다.", 4+8, 6+12);
        Debug.Log($"4+8의 값은 {4 + 8}이고 4-2의 값은 {4 - 2} 입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
