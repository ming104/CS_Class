using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str8 = String.Format("4+8�� ���� {0}�Դϴ�.", 4 + 8);
        Debug.LogFormat("4+8�� {0}�̰� 6+12�� {1}�Դϴ�.", 4+8, 6+12);
        Debug.Log($"4+8�� ���� {4 + 8}�̰� 4-2�� ���� {4 - 2} �Դϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
