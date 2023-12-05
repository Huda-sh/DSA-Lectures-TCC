using System;

namespace Lec_06_Training_Forum_Example
{
    public class MembersList
    {
        public string Name { get; set; }
        public Node First { get; set; }
        public void AddMemeberInOrderByAge(Member new_member)
        {
            Console.WriteLine("Adding new member to " + this.Name);
            Node new_node = new Node(new_member);
            if (First == null || First.Data.Age > new_member.Age)
            {
                new_node.Next = First;
                First = new_node;
                return;
            }
            Node current = First;
            while (current.Next != null && current.Next.Data.Age < new_member.Age)
                current = current.Next;
            new_node = current.Next;
            current.Next = new_node;
        }

        public void DisplayMembers()
        {
            Console.WriteLine("Displaying all members in " + this.Name);
            for (Node i = First; i != null; i = i.Next)
            {
                i.Data.Print();
            }
        }
    }
}
