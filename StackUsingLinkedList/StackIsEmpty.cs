using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList
{

    public class StackIsEmpty
    {


        class Node<T>
        {
            public T data;
            public Node<T> next;
            public Node(T data)
            {
                this.data = data;
                this.next = null;
            }
        }

        class LinkedListStack<T>
        {
            private Node<T> top;

            public LinkedListStack()
            {
                top = null;
            }

            public void Push(T data)
            {
                Node<T> node = new Node<T>(data);
                node.next = top;
                top = node;
            }

            public T Peek()
            {
                if (top == null)
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                return top.data;
            }

            public T Pop()
            {
                if (top == null)
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                T data = top.data;
                top = top.next;
                return data;
            }

        }
        public static void StackIs_Empty()
        {


            LinkedListStack<int> stack = new LinkedListStack<int>();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);

            while (true)
            {
                try
                {
                    Console.WriteLine(stack.Peek());
                    Console.WriteLine(stack.Pop());
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
        }
    }
}
