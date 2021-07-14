﻿using System;

namespace Linked_Lists
{
    class Program
    {
        internal static void DisplayOptions()
        {
            Console.WriteLine("1. Display list");
            Console.WriteLine("2. Count the number of nodes");
            Console.WriteLine("3. Search for an element");
            Console.WriteLine("4. Insert in empty list / Insert in beginning of the list");
            Console.WriteLine("5. Insert a node at the end of the list");
            Console.WriteLine("6. Insert a node after a specified node");
            Console.WriteLine("7. Insert a node before a specified node");
            Console.WriteLine("8. Insert a node at a given position");
            Console.WriteLine("9. Delete the first node");
            Console.WriteLine("10. Delete the last node");
            Console.WriteLine("11. Delete any node");
            Console.WriteLine("12. Refresh console");
            Console.WriteLine("0. Exit");
        }

        static void Main(string[] args)
        {
            int choice, data, k, x;
            SingleLinkedList list = new SingleLinkedList();
            list.CreateList();

            while (true)
            {
                DisplayOptions();

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;

                    case 2:
                        list.CountNodes();
                        break;

                    case 3:
                        Console.Write("Enter the element to be searched : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;

                    case 4:
                        Console.Write("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtBeginning(data);
                        break;

                    case 5:
                        Console.Write("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;


                    case 6:
                        Console.Write("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element after wich to insert : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        break;

                    case 7:
                        Console.Write("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before wich to insert : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;

                    case 8:
                        Console.Write("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the position at wich to insert : ");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, k);
                        break;

                    case 9:
                        list.DeleteFirstNode();
                        break;

                    case 10:
                        list.DeleteLastNode();
                        break;

                    case 11:
                        Console.Write("Enter the element to be deleted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;

                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}

