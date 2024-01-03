using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SerializationExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        exampleData data = new exampleData();
        data.number = 1756;
        data.text = "Hello";

        FileStream fs = new FileStream("C:/Users/user/OneDrive/바탕 화면/data.dat", FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs, data);
        fs.Close();

        fs = new FileStream("C:/Users/user/OneDrive/바탕 화면/data.dat", FileMode.Open);
        exampleData loadData = (exampleData)bf.Deserialize(fs);
        Debug.Log(loadData.number);
        Debug.Log(loadData.text);
    }
}

[Serializable]
class exampleData // 객체를 내부에 저장할때
{
    public int number;
    public string text;
}