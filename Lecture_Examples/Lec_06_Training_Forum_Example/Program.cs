using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_06_Training_Forum_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MembersList membersList = new MembersList();

            membersList.Name = "DSA Course";

            Member member1 = new Member();
            Console.WriteLine("------------------------------");
            Member member2 = new Member();
            Console.WriteLine("------------------------------");
            Member member3 = new Member();
            Console.WriteLine("------------------------------");
            Member member4 = new Member();

            Console.WriteLine("===============================");

            membersList.AddMemeberInOrderByAge(member1);
            Console.WriteLine("------------------------------");
            membersList.AddMemeberInOrderByAge(member2);
            Console.WriteLine("------------------------------");
            membersList.AddMemeberInOrderByAge(member3);
            Console.WriteLine("------------------------------");
            membersList.AddMemeberInOrderByAge(member4);

            Console.WriteLine("===============================");
            membersList.DisplayMembers();
        }
    }
}
