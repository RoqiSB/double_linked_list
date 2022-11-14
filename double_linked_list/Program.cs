using System;
using System.Security.Cryptography.X509Certificates;

namespace double_linked_list
{
    class Node
    {
        //Node class reoresents the node of doubly linked list.
        //it consists of the information part and links to 
        //its succeeding and preceeding
        //in terms of next and previous
        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //point to the precceeding node
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;
        
        //construktor
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode()
        {
            int nim;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student :");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
        }
    }






    
    class Program
    {
        static void Main(string[]args)
        {

        }
    }
}