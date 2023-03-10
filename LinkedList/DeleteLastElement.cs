using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DeleteLastElement
    {
        Node head;
        private Node tail;

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

        public void popLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is already empty");
                return;
            }

            if (head.next == null)
            {
                head = null;
                return;
            }

            Node current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }

            Node lastNode = current.next;
            current.next = null;
            tail = current;

            // print the popped data
            int data = lastNode.data;
            Console.WriteLine("Popped value: " + data);
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
    

        public static void DeleteLast_Element()
        {
            DeleteLastElement linked_list = new DeleteLastElement();

            // Add elements to the linked list
            linked_list.Add(56);
            linked_list.Add(30);
            linked_list.Add(70);

            // Delete the last element
            int data = linked_list.PopLast();

            Console.WriteLine("Popped data: " + data);

            // Print the linked list
            linked_list.PrintList();
        }

        private int PopLast()
        {
            throw new NotImplementedException();
        }
    }

}
