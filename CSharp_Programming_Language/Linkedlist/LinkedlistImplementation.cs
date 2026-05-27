using System.Text;
using System;
using System.Collections;

namespace CSharp_Programming_Language.Linkedlist
{

    public class Node
    {
        public Node next;
        public int data;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }


    public class LinkedlistImplementation
    {
        public Node head;

        public LinkedlistImplementation()
        {
            head = null;
        }

        public Node GetHead()
        {
            return this.head;
        }
        public void IntertAtEnd(int data)
        {
            Node new_node = new Node(data);
            if (head == null)
            {
                head = new_node;
                return;
            }

            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new_node;
        }

        public void IntertAtHead(int data)
        {
            Node new_node = new Node(data);
            if (head == null)
            {
                head = new_node;
                return;
            }

            new_node.next = head;
            head = new_node;
        }

        public void PrintLinkedList(Node node)
        {
            while (node != null)
            {
                System.Console.Write(node.data + " ");
                node = node.next;
            }

            System.Console.WriteLine();
        }
    }

}

