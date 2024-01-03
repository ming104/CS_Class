using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Subscriber sub = new Subscriber("EventExample");
        Publisher pub = new Publisher();

        pub.RunEvent();
    }
}

delegate void myEventHandler();

class Publisher
{
    public static event myEventHandler myEvent;

    public void RunEvent()
    {
        if(myEvent != null)
        {
            myEvent();
        }
    }
}

class Subscriber
{
    public Subscriber(string str) 
    {
        Debug.Log(str);
        Publisher.myEvent += DoSomething;
        Publisher.myEvent += DoSomething2;
    }

    public void DoSomething()
    {
        Debug.Log("event ¹ß»ý");
    }

    public void DoSomething2()
    {
        Debug.Log("DoSomething2");
    }
}

