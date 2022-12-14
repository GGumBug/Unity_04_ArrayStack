using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStack
{
    public int[] myStack;

    public int count = 0;
    // 들어있는 변수의 개수를 샐수있는 Count
    // 배열안에 변수를 입력하는 push
    // 배열 끝에 변수를 가져오는 pop
    // 배열안에 변수를 모두 제거 하는 clear
    // push를 하는데 배열 자리가 없을경우 Stack Overflow
    // pop 을 하는데 변수가 없는경우 Stack is Empty
    // push 범위가 넘어가도 푸쉬가 되도록

    public MyStack(int size)
    {
        myStack = new int[size];
    }

    public void Push(int data)
    {
        if (count >= myStack.Length)
        {
            //Debug.Log("Stack Overflow");
            int[] backUpStack = new int[count*2];
            for (int i = 0; i < myStack.Length; i++)
            {
                backUpStack[i] = myStack[i];
            }
            myStack = backUpStack;
            myStack[count++] = data;
        }
        else
        {
            myStack[count++] = data;
        }

    }

    public int Pop()
    {
        if (count <= 0)
        {
            Debug.Log("Stack is Empty");

            return 0;
        }
        else
        {
            return myStack[--count];
        }
    }

    public void Clear()
    {
        for (int i = 0; i < myStack.Length; i++)
        {
            myStack[i] = 0;
        }

        count = 0;
    }
}
