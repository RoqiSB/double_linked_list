﻿using System;
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


            }
        }
    }






    
    class Program
    {
        static void Main(string[]args)
        {

        }
    }
