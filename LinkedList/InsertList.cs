using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class InsertList
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

        public void Insert(int prev_data, int new_data)
        {
            Node current_node = head;
            while (current_node != null)
            {
                if (current_node.data == prev_data)
                {
                    Node new_node = new Node(new_data);
                    new_node.next = current_node.next;
                    current_node.next = new_node;
                    return;
                }
                current_node = current_node.next;
            }
            Console.WriteLine("Previous node not found in the linked list.");
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
    

        public static void Insert_List()
        {
            InsertList linked_list = new InsertList();

            linked_list.Add(56);

            linked_list.Insert(56, 30);

            linked_list.Add(70);

        
            linked_list.PrintList();
        }
    }

}
