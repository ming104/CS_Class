using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Enemy2 : Enemy
{
    private void Start()
    {

    }    
    public override void Move()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.down * speed);
    }
}