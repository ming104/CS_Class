using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Bird eagle = new Bird();
       Fish shark = new Fish();

        eagle.Move();
        shark.Move();

    }

    // Update is called once per frame
    void Update()
    {

    }
}

abstract class Animal
{
    public abstract void Move();

    public void Eat()
    {
        Debug.Log("eat");
    }
}

class Bird : Animal 
{
    public override void Move()
    {
        Debug.Log("fly");
    }
}
class Fish : Animal
{
    public override void Move()
    {
        Debug.Log("swim");
    }
}



