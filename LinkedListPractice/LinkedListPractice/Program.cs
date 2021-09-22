﻿using System;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problem");

            while (true)
            {
                Console.WriteLine("\nEnter an option:");
                Console.WriteLine("1.Add New Element \n2.Append New Element \n3.Insert New Element \n4.Remove First Element \n5.Remove Last Element \n6.Search Element \n7.Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                // choose the options from user
                switch (choice)
                {
                    case 1:
                        Operation.AddElement();
                        Console.WriteLine();
                        break;
                    case 2:
                        Operation.AppendElement();
                        break;
                    case 3:
                        Operation.InsertElement();
                        break;
                    case 4:
                        Operation.RemoveFirstElement();
                        break;
                    case 5:
                        Operation.RemoveLastElement();
                        break;
                    case 6:
                        Operation.SearchElement();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;


                    default:

                        Console.WriteLine("\nEnter Vaild Choice\n");
                        break;
                }
            }

        }
    }
}
