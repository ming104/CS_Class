using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastExample : MonoBehaviour
{
    public GameObject Box;
    private Rigidbody rigid;
   
    // Start is called before the first frame update
    void Start()
    {
        GameObject BoxPrefab = Instantiate(Box) as GameObject;

        BoxPrefab.GetComponent<Rigidbody>();
        Debug.Log("mass : " + rigid.mass);
        rigid.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
