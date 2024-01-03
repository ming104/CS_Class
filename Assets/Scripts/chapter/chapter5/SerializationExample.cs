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

        FileStream fs = new FileStream("C:/Users/user/OneDrive/���� ȭ��/data.dat", FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs, data);
        fs.Close();

        fs = new FileStream("C:/Users/user/OneDrive/���� ȭ��/data.dat", FileMode.Open);
        exampleData loadData = (exampleData)bf.Deserialize(fs);
        Debug.Log(loadData.number);
        Debug.Log(loadData.text);
    }
}

[Serializable]
class exampleData // ��ü�� ���ο� �����Ҷ�
{
    public int number;
    public string text;
}