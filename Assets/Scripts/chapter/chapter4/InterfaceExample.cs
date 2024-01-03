using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

class Knight : ISword, IShield
{
    public string Damage { get; set; }
    public string DefensivePower { get; set; }

    public void Attack()
    {

    }

    public void Defend()
    {

    }


}


interface ISword
{
    string Damage { get; set; }
    void Attack();
}

interface IShield
{
    string DefensivePower { get; set; }
    void Defend();
}

