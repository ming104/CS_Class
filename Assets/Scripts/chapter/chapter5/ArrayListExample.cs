 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListExample : MonoBehaviour
{
    ArrayList myAL = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {
        myAL.Add(134);
        myAL.Add("Hello");
        myAL.Add(1275.97f);

        Debug.Log(myAL[0]);
        Debug.Log(myAL[1]);
        Debug.Log(myAL[2]);
        Debug.Log(myAL.Count);
        Debug.Log("+========================+");

        myAL.Remove("Hello");
        myAL.RemoveAt(0);

        Debug.Log(myAL[0]);
        //Debug.Log(myAL[1]);
        Debug.Log(myAL.Count);
        Debug.Log("+========================+");

        myAL.Insert(0, "World");
        myAL.Insert(0, "Hello");

        Debug.Log(myAL.Count);
        Debug.Log("+========================+");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
