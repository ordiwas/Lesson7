using System;
using System.Collections.Generic;

namespace WorkingWithPriorityQueues
{
    public class Patient
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public Patient(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates the members list with patient objects and their priorities
            // serves as seed data
            var patients = new List<(Patient, int)>()
            {
             (new("Sarah Jones", 23), 4),
             (new("Joe Schmoo", 50), 2),
             (new("Elizabeth Lochlan", 60), 1),
             (new("Natalie O'Malley", 16), 5),
             (new("Angie Woods", 25), 3)
            };
            // Creates a priority queue and adds the List of patients and priorities to the queue 
            var hospitalQueue = new PriorityQueue<Patient, int>(patients);
            int selection = Menu();
            string name;
            int age, priority;
            while (selection != 4)
            {
                switch (selection)
                {
                    case 1: // Add
                        Console.WriteLine("Patient name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Age: ");
                        age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Patient Priority: ");
                        priority = int.Parse(Console.ReadLine());
                        hospitalQueue.Enqueue(new Patient(name, age), priority);
                        break;
                    case 2:// Checking the patient queue for the highest priority patient
                        // 2 ways to check  TryPeek is safer because queue may be empty
                        //var highestPriorityPatient = hospitalQueue.Peek();
                        //Console.WriteLine($"Highest priority patient: {highestPriorityPatient.Name}, Age {highestPriorityPatient.Age}");
                        hospitalQueue.TryPeek(out Patient nextPatient, out int patientPriority);
                        Console.WriteLine($"Highest priority patient: {nextPatient.Name}, Age {nextPatient.Age}");
                        break;
                    case 3: // Removing highest priority (treating and discharging)
                        // 2 ways to remove.  TryDequeue is safer
                        //var highestPriorityPatient = hospitalQueue.Dequeue();
                        //Console.WriteLine($"Highest priority patient: {highestPriorityPatient.Name}, Age {highestPriorityPatient.Age}");
                        hospitalQueue.TryDequeue(out Patient dischargePatient, out int dischargePriority);
                        Console.WriteLine($"Patient treated and discharged: {dischargePatient.Name}, Age {dischargePatient.Age}");
                        break;
                    default:
                        Console.WriteLine("You have made an invalid selection, please try again");
                        break;
                }
                selection = Menu();
            }

        }
        static int Menu()
        {
            Console.WriteLine("Patient Priority Queue");
            Console.WriteLine("1 to Add a Patient\n2 to View the Highest Priority Patient\n3 to Treat and Discharge\n4 to Quit");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}