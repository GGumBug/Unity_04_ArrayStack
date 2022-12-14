using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyStack stack = new MyStack(3);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);



        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());

    }
}
