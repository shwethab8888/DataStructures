using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingLinkedList
{
    internal class LinkedListDeQueue
    {
       
            private class Node
            {
                public int Value;
                public Node Next;

                public Node(int value)
                {
                    Value = value;
                    Next = null;
                }
            }

            private Node head;
            private Node tail;

            public void Enqueue(int value)
            {
                Node newNode = new Node(value);

                if (tail == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.Next = newNode;
                    tail = newNode;
                }
            }

            public int Dequeue()
            {
                if (head == null)
                {
                    throw new InvalidOperationException("Queue is empty");
                }

                int value = head.Value;
                head = head.Next;

                if (head == null)
                {
                    tail = null;
                }

                return value;
            }

            public int Peek()
            {
                if (head == null)
                {
                    throw new InvalidOperationException("Queue is empty");
                }

                return head.Value;
            }

            public bool IsEmpty()
            {
                return head == null;
            }

        public void DequeueFromBeginning()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            int value = head.Value;
            head = head.Next;

            Console.WriteLine($"Dequeued value from beginning: {value}");
        }

        public static void LinkedList_DeQueue()
        {
            LinkedListDeQueue myQueue = new LinkedListDeQueue();

            myQueue.Enqueue(56);
            myQueue.Enqueue(30);
            myQueue.Enqueue(70);

            while (!myQueue.IsEmpty())
            {
                int value = myQueue.Dequeue();
                Console.WriteLine($"Dequeued value: {value}");
            }

            myQueue.Enqueue(56);
            myQueue.Enqueue(30);
            myQueue.Enqueue(70);

            while (!myQueue.IsEmpty())
            {
                myQueue.DequeueFromBeginning();
            }

        }
    }
}
