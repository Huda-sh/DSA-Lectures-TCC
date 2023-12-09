using System;

namespace Lec_06_Training_Forum_Example
{
    public enum AchivmentDegree
    {
        Primary_School,
        Middle_School,
        High_School,
        University
    }
    public class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        static int last_available_id = 1;
        public AchivmentDegree Education { get; set; }

        public Member()
        {
            ID = last_available_id;
            last_available_id++;
            Console.WriteLine("Granted ID: " + ID);
            Console.WriteLine("Input name:");
            Name = Console.ReadLine();
            Console.WriteLine("Input Age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose Achievement degree:");
            int choice;
            do
            {
                Console.WriteLine("1-Primary school.");
                Console.WriteLine("2-Middle school.");
                Console.WriteLine("3-High School.");
                Console.WriteLine("4-University.");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case (1):
                        Education = AchivmentDegree.Primary_School;
                        break;
                    case (2):
                        Education = AchivmentDegree.Middle_School;
                        break;
                    case (3):
                        Education = AchivmentDegree.High_School;
                        break;
                    case (4):
                        Education = AchivmentDegree.University;
                        break;
                    default:
                        Console.WriteLine("Please choose a choice from the list above!");
                        break;
                }
            }
            while (choice != 1 && choice != 2 && choice != 3 && choice != 4);
        }

        public void Print()
        {
            Console.WriteLine("Member Information:");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Achievement degree: " + Education);
            Console.WriteLine();
        }
    }
}
