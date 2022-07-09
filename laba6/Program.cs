using System;
using static System.Console;

namespace laba6ASD
{
    class Program
    {
        public static void Main()
        {
            Deque deque = new Deque();
            string command = "command";
            string input;
            bool check = true;

            while (command != "End")
            {
                WriteLine("Enter one of the keywords: \n Example - control example with a ready-made key \n Enter - handwritten input \n End - exit the program");
                command = ReadLine();

                if (command == "Example")
                {
                    string example = "90167899876109";
                    WriteLine("\n----------------------------");
                    WriteLine("Example word is " + example);
                    WriteLine("----------------------------");

                    KeyToDeque(deque, example);

                    if (deque.KeyIsPalindrome())
                        Print(deque);
                    else
                        WriteLine("\nThis key is not palindrome");
                }
                else if (command == "Enter")
                {
                    do
                    {
                        deque = new Deque();
                        WriteLine("Enter key: ");
                        input = ReadLine();

                        while (input.Length == 0 || input.Length % 2 != 0)
                        {
                            WriteLine("This is not palindrome, try again. ");
                            input = ReadLine();
                        }

                        KeyToDeque(deque, input);
                        check = deque.KeyIsPalindrome();

                        if (!check)
                        {
                            WriteLine("This is not palindrome, try again. ");
                        }
                    }
                    while (!check);
                    Print(deque);
                }

                else if (command == "End")
                    break;
                else
                {
                    WriteLine("\nERROR INPUT, PLEASE TRY AGAIN !!!");
                }
            }
        }
        static public void Print(Deque deque)
        {
            WriteLine("\n____________________________\nThis key is palindrome.\n____________________________");
            deque.HalfDeque();
            deque.Transposition();
            WriteLine();
        }
        static public void KeyToDeque(Deque deque, string input)
        {
            for (int i = 0; i < input.Length; i++)
                deque.insertTail(input[i]);
            deque.printDeque();
        }
        public class Deque
        {
            private Node Head;
            private Node Tail;
            private int Size;
            public Deque()
            {
                Head = null;
                Tail = null;
                Size = 0;
            }
            public bool isEmpty()
            {
                if (this.Head == null)
                    return true;
                else
                    return false;
            }
            public void insertHead(char buffer)
            {
                Node node = new Node(buffer);
                node.next = this.Head;
                if (this.Head == null)
                {
                    this.Head = node;
                    this.Tail = node;
                }
                else
                {
                    this.Head.prev = node;
                    this.Head = node;
                }
                this.Size++;
                this.printDeque();
            }
            public Deque Copy()
            {
                Deque clone = new Deque();
                Node node = this.Head;
                while (node != null)
                {
                    clone.insertTail(node.data);
                    node = node.next;
                }
                return clone;
            }
            public void insertTail(char buffer)
            {
                Node node = new Node(buffer);
                if (this.Head == null)
                {
                    this.Head = node;
                    this.Tail = node;
                }
                else
                {
                    node.prev = this.Tail;
                    this.Tail.next = node;
                    this.Tail = node;
                }
                this.Size++;
                this.printDeque();
            }
            public void removeTail()
            {
                if (this.isEmpty() == true)
                {
                    return;
                }
                this.Tail = this.Tail.prev;

                if (this.Tail == null)
                {
                    this.Head = null;
                }
                else
                {
                    this.Tail.next = null;
                }
                this.Size--;

                this.printDeque();
                
            }
            public void removeHead()
            {
                if (this.isEmpty() == true)
                {
                    return;
                }
                this.Head = this.Head.next;
                if (this.Head == null)
                {
                    this.Tail = null;
                }
                else
                {
                    this.Head.prev = null;
                }
                this.Size--;
                this.printDeque();
                
            }


            public void printDeque()
            {
                Node node = this.Head;
                WriteLine();
                if (node != null)
                {
                    while (node != null)
                    {
                        Write(node.data);
                        node = node.next;
                    }
                }
                else
                    WriteLine("\n____________________________\nThis deque is empty.\n____________________________");
            }
            public bool KeyIsPalindrome()
            {
                WriteLine("\n____________________________\nCreate copy of the deque: ");
                Deque current = this.Copy();
                WriteLine("\n____________________________");
                if (!current.isEmpty())
                {
                    WriteLine("\n____________________________\nRemoving elements from a copy: ");
                    do
                    {
                        if (current.Head.data == current.Tail.data)
                        {
                            current.removeTail();
                            current.removeHead();
                        }
                        else
                            return false;
                    }
                    while (!current.isEmpty());
                    return true;
                }
                else return false;
            }
            public void HalfDeque()
            {
                string half = "";
                WriteLine("\n____________________________\nCreate copy of the deque: ");
                Deque current = this.Copy();
                WriteLine("\n____________________________");

                WriteLine("\n____________________________\nRemoving elements from a copy:");
                while (!current.isEmpty())
                {
                    half += current.Tail.data;

                    current.removeHead();
                    current.removeTail();
                }
                WriteLine($"\n____________________________\nHalf of the deque: {half}\n____________________________");
            }
            public void Transposition()
            {
                WriteLine("\n____________________________\nPermutation of elements: ");
                for (int i = 0; i < this.Size / 2; i++)
                {
                    this.insertHead(this.Tail.data);
                    this.removeTail();
                }
                this.printDeque();
                WriteLine("\n____________________________");
            }
        }
        public class Node
        {
            public char data;
            public Node next;
            public Node prev;
            public Node(char data)
            {
                this.data = data;
                this.prev = null;
                this.next = null;
            }
        }
    }

}