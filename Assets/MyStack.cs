using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStack
{
    public int[] myStack;

    public int count = 0;
    // ����ִ� ������ ������ �����ִ� Count
    // �迭�ȿ� ������ �Է��ϴ� push
    // �迭 ���� ������ �������� pop
    // �迭�ȿ� ������ ��� ���� �ϴ� clear
    // push�� �ϴµ� �迭 �ڸ��� ������� Stack Overflow
    // pop �� �ϴµ� ������ ���°�� Stack is Empty
    // push ������ �Ѿ�� Ǫ���� �ǵ���

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
