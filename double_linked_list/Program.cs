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
            newNode.name = nm;

            //check if the list empty
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number not allowed ");
                    return;
                }
                newNode.next = START;
                if(START != null)
                    START.prev = newNode;
                newNode.prev = null;
                START = newNode;
                return;
            }
            //if the node is to be inserted at between two node
            Node previous, current;
            for (current = previous = START;
                current != null && nim >= current.noMhs;
                previous = current, current = current.next)
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return ;
                }
            }
            //on the execution of the aboce for loop, prev and
            //current will point to those nodes
            //between wich the new node is to be insarted
            newNode.next = current;
            newNode.prev = previous;

            //if the node is to be insarted at the end of the list
            if (current == null)
            {
                newNode.next = null;
                previous.next = newNode;
                return;
            }
            current.prev = newNode;
            previous.next = newNode;
            }
        public bool search(int rollNo, ref Node previous, ref Node current)
        {
            for (previous = current = START; current != null &&
                rollNo != current.noMhs; previous = current,
                current = current.next) { }
            return (current != null);
        }
        public bool dellNode(int rollno)
        {
            Node previous, current;
            previous = current = null;
            if (search(rollno, ref previous, ref current) == false)
                return false;
            //the begining of data
            if(current.next == null)
            {
                previous.next = null;
                return true;
            }
            //node between two node in the list
            if(current == START)
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true;
            }
            // if the to be deleted is in between the list then the following llines of is executed
            previous.next = current.next;
            current.next.prev = previous;
            return true;
            }
            public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }
        }
    }






    
    class Program
    {
        static void Main(string[]args)
        {

        }
    }
