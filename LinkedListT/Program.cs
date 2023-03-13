using System;
using System.Text;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        // Create the link list.
        string[] friends =
            { "Mickey", "Minnie", "Donald", "Pluto", "Goofy", "Daisy" };
        LinkedList<string> friendList = new LinkedList<string>(friends);
        Console.WriteLine("Original friend list");
        foreach (string friend in friendList)
        {
            Console.WriteLine(friend);
        }
        Console.WriteLine();

        friendList.AddLast("Clarabell");
        friendList.AddFirst("Scrooge");

        //Retrieving the node associated wtih Donald
        LinkedListNode<string> targetLocation = friendList.Find("Donald");
        //Using the Next property of LinkedListNode < T > to display the value of the next friend
        Console.WriteLine("The current friend in the list after Donald is {0}", targetLocation.Next.Value);
        Console.WriteLine();
        friendList.AddAfter(targetLocation, "Pete");
        friendList.AddBefore(targetLocation, "Hewey");
        Console.WriteLine("List with additions");
        foreach (string friend in friendList)
        {
            Console.WriteLine(friend);
        }
        Console.WriteLine();
        friendList.RemoveFirst();
        friendList.RemoveLast();
        Console.WriteLine("List after deletions");
        foreach (string friend in friendList)
        {
            Console.WriteLine(friend);
        }
        Console.WriteLine();

        // Create an array with the same number of
        // elements as the linked list.
        string[] friendArray = new string[friendList.Count];
        friendList.CopyTo(friendArray, 0);
        Console.WriteLine("friendList is now friendArray");
        foreach (string f in friendArray)
        {
            Console.WriteLine(f);
        }

        // Release all the nodes.
        friendList.Clear();


    }

}