using System;
using System.Collections.Generic;

namespace FunwithQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates the members queue
            Queue<string> members = new Queue<string>();

            //adding members
            members.Enqueue("Billy Bob");
            members.Enqueue("Bobby Bill");

            // adding more members
            Console.WriteLine("How many members would you like to add?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Member name: ");
                members.Enqueue(Console.ReadLine());
            }

            // counts the members in the queue
            Console.WriteLine($"Here are your {members.Count()} members");
            // displays the queue contents without removing anything
            foreach (var m in members)
            {
                Console.WriteLine(m);
            }

            // views the first item in the queue and displays it to determine if the user wants to remove it
            string firstMem = members.Peek();
            Console.WriteLine($"Would you like to remove {firstMem} from the beginning of the queue (yes or no)?");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                members.Dequeue(); // removes item from the top of the queue
                firstMem = members.Peek();
                Console.WriteLine($"Would you like to remove {firstMem} from the beginning of the queue (yes or no)?");
                answer = Console.ReadLine();
            }

            if (members.Peek() == null)
                Console.WriteLine("The queue is empty");
            else
                Console.WriteLine($"You have {members.Count} left in the queue");

        }
    }
}