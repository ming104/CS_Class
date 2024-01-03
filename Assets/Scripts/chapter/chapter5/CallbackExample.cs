using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallbackExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mother mother = new Mother();
        Son son = new Son();

        mother.GetSonToStudy(son);
    }


}

class Mother
{
    public void GetSonToStudy(Son son)
    {
        son.Study(this);
    }

    public void FinishStudy()
    {
        Debug.Log("Study done");
    }
}
    

class Son
{
    public void Study(Mother mother)
    {
        mother.FinishStudy();
    }
}
