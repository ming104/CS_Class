using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassExample : MonoBehaviour
{
}

class Human
{
    private string name;
    private float height;
    public int age;

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int _age)
    {
        age = _age;
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public float Height
    {
        get { return height; }
        set { height = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Human(string _name)
    {
      name = _name;
    }

    public Human(string _name, int _age)
    {
        name = _name;
        age = _age;
    }

    public Human(string _name, int _age, float _height)
    {
        name = _name;
        age = _age;
        height = _height;

    }
    public void Eat()
    {
        Debug.Log("eat");
    }

    public virtual void Walk()
    {
        Debug.Log("Walk");
    }

    public void Sleep()
    {
        Debug.Log("Sleep");
    }
}



