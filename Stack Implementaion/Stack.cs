using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementaion
{
    //to representing elements in the stack
    class Node<T>
    {
        public T Value;
        public Node<T> Next;

    }

    internal class Stack<T>
    {
        Node<T> Top; // // Points to the top of the stack
        public Stack()
        {
            Top = null;
        }

        //check if the stack is empty or has elements
        bool isEmpty() { return Top == null; }

        // Method to insert a new element to the stack
        public void Push(T Value)
        {
            Node<T> NewNode = new Node<T>();
            NewNode.Value = Value;
            NewNode.Next = Top;
            Top = NewNode;

        }
        //Method to Delete top element from stack and return it
        public T Pop()
        {
            T value;
            if (isEmpty())
            {
                throw new InvalidOperationException("Stack is Empty");

            }
            else
            {
                Node<T> temp = new Node<T>();
                temp = Top;
                Top = Top.Next;
                value = temp.Value;
                temp = null;
            }
            return value;


        }

        //view a top element from stack without remove it
        public void Peek()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Stack is Empty");
            }
            else
            {
                Console.WriteLine(Top.Value);
            }
        }

        //search for element in the stack
        public bool Search(T value)
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Stack is Empty");

            }
            Node<T> temp = Top;
            while (temp != null)
            {
                if (temp.Value.Equals(value))
                    return true;
                temp = temp.Next;
            }
            return false;
        }

        //display elements in the stack
        public void Display()
        {
            Node<T> temp = Top;
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.Value);
                    temp = temp.Next;
                }
            }

        }
    }
}
