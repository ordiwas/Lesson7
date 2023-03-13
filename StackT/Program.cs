using System;
using System.Collections.Generic;

namespace FunwithStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates the members Stack
            Stack<string> members = new Stack<string>();
            //adding members
            members.Push("Mickey Mouse");
            members.Push("Minnie Mouse");
            // adding more members
            Console.WriteLine("How many members would you like to add?");
            int num = int.Parse(Console.ReadLine());
            // adds data to the members Stack
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Member name: ");
                members.Push(Console.ReadLine());
            }
            // Check for an item in the Stack
            Console.WriteLine("Would you like to look for a member (yes or no)");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                Console.WriteLine("Enter the name of the member you would like to search for");
                string memberName = Console.ReadLine();
                if (members.Contains(memberName))
                {
                    Console.WriteLine("That member is part of the group.");
                }
                else
                {
                    Console.WriteLine("I am sorry, that person is not part of the group");
                }
                Console.WriteLine("Would you like to look for another member (yes or no)");
                answer = Console.ReadLine();
            }
            // counts the members in the Stack
            Console.WriteLine($"Here are your {members.Count()} members");
            // displays the Stack contents without removing anything
            foreach (var m in members)
            {
                Console.WriteLine(m);
            }
            string firstMem = members.Peek();   // retrieves the LAST item
            Console.WriteLine($"Would you like to remove {firstMem} from the end of the Stack (yes or no)?");
            answer = Console.ReadLine();
            while (answer == "yes")
            {
                members.Pop();  // Removes the LAST item
                firstMem = members.Peek();
                Console.WriteLine($"Would you like to remove {firstMem} from the end of the Stack (yes or no)?");
                answer = Console.ReadLine();
            }

            if (members.Peek() == null)
                Console.WriteLine("The Stack is empty");
            else
                Console.WriteLine($"You have {members.Count} left in the Stack");

        }
    }
}