namespace Binary_Number_with_Alternating_Bits
{
    /*
     Segue o link deste desafio: https://leetcode.com/problems/binary-number-with-alternating-bits/?envType=daily-question&envId=2026-02-18
     
     
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Insira o numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(HasAlternatingBits(n));

        }

        public static bool HasAlternatingBits(int n)
        {
            string bin = IntegerToBinary(n);

            char[] bins = bin.ToCharArray();

            LinkedList linkedList = new LinkedList();

            foreach (char b in bins)
            {
                linkedList.AddLast(b);
            }

            Node current = linkedList.Head;
            while(current != null)
            {
                if (current.Next != null)
                {
                    if (current.Data == current.Next.Data)
                    {
                        return false;
                    }
                }
                current = current.Next;
            }

            return true;
        }

        public static string IntegerToBinary(int n)
        {
            return Convert.ToString(n, 2);
        }

        public class Node
        {
            public char Data;
            public Node Next;

            public Node(char value)
            {
                Data = value;
                Next = null;
            }
        }

        public class LinkedList
        {
            public Node Head;


            public void AddLast(char data)
            {
                Node newNode = new Node(data);

                if(Head == null)
                {
                    Head = newNode;
                    return;
                }

                Node current = GetLastNode();

                current.Next = newNode;
            }

            public Node GetLastNode()
            {
                Node current = Head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                return current;
            }
        }
    }
}


