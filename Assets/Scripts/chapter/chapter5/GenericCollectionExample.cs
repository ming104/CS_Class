using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericCollectionExample : MonoBehaviour
{
    List<int> myList = new List<int>();
    Queue<int> myQueue = new Queue<int>();
    Stack<int> myStack = new Stack<int>();
    Dictionary<string, int> myDictionary = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start()
    {
        // List
        Debug.Log("List/////////////////////////");
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.RemoveAt(1);
        Debug.Log(myList[0]);
        Debug.Log(myList[1]);

        // Queue
        Debug.Log("Queue/////////////////////////");
        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);
        Debug.Log(myQueue.Peek());
        Debug.Log(myQueue.Dequeue());
        Debug.Log(myQueue.Dequeue());
        Debug.Log(myQueue.Dequeue());

        //Stack
        Debug.Log("Stack ///////////////////////////");
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        Debug.Log(myStack.Peek());
        Debug.Log(myStack.Pop());
        Debug.Log(myStack.Pop());
        Debug.Log(myStack.Pop());

        //Dictionary
        Debug.Log("Dictionary//////////////////////////////");
        myDictionary.Add("first", 1);
        myDictionary.Add("second", 2);
        myDictionary.Add("third", 3);
        myDictionary.Remove("second");
        Debug.Log(myDictionary["First"]);
        Debug.Log(myDictionary["third"]);
    }
}
