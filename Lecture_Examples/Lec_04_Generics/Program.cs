using System;

namespace Lec_04_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose example:");
            Console.WriteLine("1- Equality test");
            Console.WriteLine("2- Linear Search");
            int opt = Convert.ToInt32(Console.ReadLine());
            if (opt == 1)
            {
                FirstExample();
            }
            else if (opt == 2)
            {
                SecondExample();
            }
            else
            {
                Console.WriteLine("Invalid try again!!");
            }
        }
        static void FirstExample()
        {
            Console.WriteLine("Input two int values");
            int int1 = Convert.ToInt32(Console.ReadLine());
            int int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Equality.Test(int1, int2));

            Console.WriteLine(Equality.TestObj(3, 3));

            Console.WriteLine(Equality.TestGeneric<int>(3, 3));

            Console.WriteLine("Input two char values");
            char ch1 = Convert.ToChar(Console.ReadLine());
            char ch2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Equality.Test(ch1, ch2));

            Console.WriteLine(Equality.TestObj(ch1, ch2));

            Console.WriteLine(Equality.TestGeneric<char>(ch1, ch2));

            Console.WriteLine("Input two string values");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine(Equality.Test(str1, str2));

            Console.WriteLine(Equality.TestObj(str1, str2));

            Console.WriteLine(Equality.TestGeneric<string>(str1, str2));
        }
        static void SecondExample()
        {

            int[] a = { 10, 44, -3, 7, 201, 50 };
            LinearSearch<int> int_values = new LinearSearch<int>();
            int_values.Print(a);

            Console.WriteLine("Input your int target value:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(int_values.IterativeLinearSearch(a, x1));

            Console.WriteLine("Input your int target value:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(int_values.RecursiveLinearSearch(a, x2, 0));

            Console.WriteLine("==================================================");

            string[] b = { "It's", "a ", "nice ", "day!" };
            LinearSearch<string> string_values = new LinearSearch<string>();
            string_values.Print(b);

            Console.WriteLine("Input your string target value:");
            string x3 = Console.ReadLine();

            Console.WriteLine(string_values.IterativeLinearSearch(b, x3));

            Console.WriteLine("Input your string target value:");
            string x4 = Console.ReadLine();

            Console.WriteLine(string_values.RecursiveLinearSearch(b, x4, 0));

            Console.WriteLine("==================================================");

            char[] c = { 'A', 'B', 'C', 'D', 'E', 'F', 'M' };
            LinearSearch<char> char_values = new LinearSearch<char>();
            char_values.Print(c);

            Console.WriteLine("Input your char target value:");
            char x5 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(char_values.IterativeLinearSearch(c, x5));

            Console.WriteLine("Input your char target value:");
            char x6 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(char_values.RecursiveLinearSearch(c, x6, 0));
        }
    }
}
