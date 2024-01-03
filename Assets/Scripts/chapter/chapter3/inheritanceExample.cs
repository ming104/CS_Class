using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inheritanceExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Adult john = new Adult("john", 28, 173);
        //Baby lisa = new Baby("lisa", 3, 95);
        //Debug.Log(john.Age);
        //lisa.Sleep();

        //Adult maria = new Adult("maria", 10, 12);
        //maria.Age = 1;
        //maria.SetBaseAge(2);
        //Debug.Log(maria.Age);
        //Debug.Log(maria.GetBaseAge());

        Baby jake = new Baby("jake", 3, 62);
        jake.Walk();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
class Adult : Human
{
    public Adult(string _name, int _age, float _height) : base(_name, _age, _height) { }

    public void PrintAddress()
    {
        Debug.Log("address");
    }

    public int Age;
    public void SetBaseAge(int age)
    {
        base.age = age;
    }

    public int GetBaseAge()
    {
        return base.Age;
    }
}

class Baby : Human
{
    public Baby(string _name, int _age, float _height) : base(_name, _age, _height) { }

    public new void Walk()
    {
        Debug.Log("crawl");
    }
}