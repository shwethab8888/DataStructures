using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DeleteFirstElement
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

        public int Pop()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Cannot pop from an empty linked list.");
            }

            int popped_data = head.data;
            head = head.next;

            return popped_data;
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
    

        public static void DeleteFirst_Element()
        {
            DeleteFirstElement linked_list = new DeleteFirstElement();

            // Add elements to the linked list
            linked_list.Add(56);
            linked_list.Add(30);
            linked_list.Add(70);

            // Delete the first element
            int popped_data = linked_list.Pop();

            Console.WriteLine("Popped data: " + popped_data);

            // Print the linked list
            linked_list.PrintList();
        }
    }


}
