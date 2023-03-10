using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    //public class Node
    //{
    //    public int data;
    //    public Node next;
    //    public Node(int d)
    //    {
    //        data = d;
    //        next = null;
    //    }
    //}

    public class FirstCreate
    {
        Node head;

        public void Add(int data)
        {
            Node new_node = new Node(data);

            if (head == null)
            {
                head = new_node;
                return;
            }

            Node current_node = head;
            while (current_node.next != null)
            {
                current_node = current_node.next;
            }

            current_node.next = new_node;
        }

        public void AddAfter(int key, int data)
        {
            Node current_node = head;
            while (current_node != null)
            {
                if (current_node.data == key)
                {
                    Node new_node = new Node(data);
                    new_node.next = current_node.next;
                    current_node.next = new_node;
                    return;
                }
                current_node = current_node.next;
            }
            Console.WriteLine(key + " not found in the linked list");
        }

        public void PrintList()
        {
            Node current_node = head;
            while (current_node != null)
            {
                Console.Write(current_node.data + "->");
                current_node = current_node.next;
            }
            Console.WriteLine("null");
        }
    

        public static void First_Create()
        {

            FirstCreate linked_list = new FirstCreate();

            
            linked_list.Add(70);

            linked_list.AddAfter(70, 30);

            linked_list.AddAfter(30, 56);

            linked_list.PrintList();
        }
    }

}
