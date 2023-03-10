using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class AppendCreateList
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

        public void Append(int data)
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
    

        public static void Append_CreateList()
        {
            AppendCreateList linked_list = new AppendCreateList();

            // Add the first element
            linked_list.Add(56);

            // Append 30 to 56
            linked_list.Append(30);

            // Append 70 to 30
            linked_list.Append(70);

            // Print the linked list
            linked_list.PrintList();
        }
    }

}
