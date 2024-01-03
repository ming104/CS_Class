using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticUsageExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Member john = new Member("john", 21);
        Member jane = new Member("jane", 23);

        Debug.Log($"{Member.NumOfMenbers}");
    }

    // Update is called once per frame       
    void Update()
    {

    }
}
class Member
{
    public string name;
    public int age;
    public static int NumOfMenbers;

    public Member(string name, int age) 
    {
        this.name = name;
        this.age = age;
        NumOfMenbers ++;
    }
}

