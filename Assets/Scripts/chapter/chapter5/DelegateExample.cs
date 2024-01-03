using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    delegate void HumanDelegate();

    // Start is called before the first frame update
    void Start()
    {
        HumanDelegate human = Walk;
        human += Eat;
        human += Sleep;

        human();
    }

    void Walk()
    {
        Debug.Log("Walk");
    }
    void Eat()
    {
        Debug.Log("Eat");
    }
    void Sleep()
    {
        Debug.Log("Sleep");
    }
}
