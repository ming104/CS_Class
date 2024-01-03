using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Human Alice = new Human("alice", 23, 160);
        //Alice.Age = 15;
        //Debug.Log(Alice.Age);

        Human Kelly = new Human("alice", 30, 167);
        Kelly.Age = 27;
        Debug.Log(Kelly.GetAge());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
