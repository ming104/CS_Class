using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoManager : MonoBehaviour
{
    public Button goButton;

    public void Start()
    {
        goButton.onClick.AddListener(()=>OnClickGO("HI"));
    }

    public void OnClickGO(string str)
    {
        Debug.Log(str);
    }
}
