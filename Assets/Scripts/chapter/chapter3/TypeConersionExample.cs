using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeConersionExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Adult maria = new Adult("maria", 10, 12);
        Human human = maria;

        //Human ming10 = new Human("ming", 10, 12);  //������!
        //Adult au = (Adult)ming10;

        Human Paul = new Human("Paul", 3, 90);
        Baby baby = Paul as Baby;

        if(baby == null)
        {
            Debug.Log("����ȯ ����!");
        }
        else
        {
            Debug.Log("����ȯ ����!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
