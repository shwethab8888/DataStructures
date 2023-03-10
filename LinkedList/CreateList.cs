using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    public class CreateList
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

            Node last_node = head;
            while (last_node.next != null)
            {
                last_node = last_node.next;
            }

            last_node.next = new_node;
        }

        public void PrintList()
        {
            Node current_node = head;
            while (current_node != null)
            {
                Console.Write(current_node.data + " ");
                current_node = current_node.next;
            }
            Console.WriteLine();
        }
    

        public static void Create_List()
        {
            CreateList linked_list = new CreateList();

            // Add elements
            linked_list.Add(56);
            linked_list.Add(30);
            linked_list.Add(70);

            // Print the linked list
            linked_list.PrintList();
        }
    }

}
