using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataClass<int> DC = new DataClass<int>();
        DC.data = 1;
        Debug.Log(DC.GetData());

        DataClass<float> DC2 = new DataClass<float>();
        DC2.data = 127.8f;
        Debug.Log(DC2.GetData());
    }
}

class DataClass<T>
{
    public T data;

    public T GetData()
    {
        return data;
    }
}

