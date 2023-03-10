using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList
{

    internal class CreateStack
    {

        public class Node<T>
        {
            public T data;
            public Node<T> next;

            public Node(T data)
            {
                this.data = data;
                this.next = null;
            }
        }

        public class Stack<T>
        {
            private Node<T> top;

            public Stack()
            {
                this.top = null;
            }

            public void Push(T data)
            {
                Node<T> newNode = new Node<T>(data);
                if (this.top == null)
                {
                    this.top = newNode;
                }
                else
                {
                    newNode.next = this.top;
                    this.top = newNode;
                }
            }

            public T Pop()
            {
                if (this.top == null)
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                else
                {
                    T data = this.top.data;
                    this.top = this.top.next;
                    return data;
                }
            }

            public void PrintTop()
            {
                if (this.top == null)
                {
                    Console.WriteLine("Stack is empty");
                }
                else
                {
                    Console.WriteLine(this.top.data);
                }
            }

            public bool IsEmpty()
            {
                return (this.top == null);
            }
        }

        public static void Create_Stack()
        {

            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            Console.WriteLine(stack.Pop()); // prints 56
            stack.PrintTop(); // prints 30
            Console.WriteLine(stack.Pop()); // prints 30
            Console.WriteLine(stack.Pop()); // prints 70
            Console.WriteLine(stack.IsEmpty()); // prints True

            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("hello");
            stringStack.Push("world");
            stringStack.Push("!");

            Console.WriteLine(stringStack.Pop()); // prints "!"
            stringStack.PrintTop(); // prints "world"
            Console.WriteLine(stringStack.Pop()); // prints "world"
            Console.WriteLine(stringStack.Pop()); // prints "hello"
            Console.WriteLine(stringStack.IsEmpty()); // prints True

        }

    }
}
