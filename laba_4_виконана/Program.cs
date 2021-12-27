using System;
using System.Collections.Generic;
using static System.Console;


    public class Node
    {
        public Node next;
        public Object data;
    }

    public class LinkedList
    {
        private Node head;

    public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

        public void AddToPosition(string number, int position)
        {
            Node temp = new Node();
            Node temp1 = head;
            for (int i = 1; i < position - 1; i++)
            {
                temp1 = temp1.next;
            }
            temp.next = temp1.next;
            temp1.next = temp;
        }
        public void DeleteFromPosition(int position)
        {
            if (head == null)
                return;
            Node temp = head;

            if (position == 0)
            {
                head = temp.next;
                return;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();

        string KeyExit = "Exit";     // ключевое слово для выхода
        string KeyAddF = "AddFirst";
        string KeyAddL = "AddLast";
        string KeyAddP = "AddAtPosition";
        string KeyDelF = "DeleteFirst";
        string KeyDelL = "DeleteLast";
        string KeyDelP = "DeleteAtPosition";
        string KeyPrin = "Print";
        string KeyNode = "AddNode";

        try
        {
            for (; ; )
            {
                WriteLine("Доступные команды для ввода: ");
                if (list.Count > 2)
                {
                    WriteLine("Exit AddFirst AddLast AddAtPosition DeleteFirst DeleteLast DeleteAtPosition Print AddNode");
                }
                else if (list.Count > 1)
                {
                    WriteLine("Exit AddFirst AddLast AddAtPosition DeleteFirst DeleteLast DeleteAtPosition Print");
                }
                else
                {
                    WriteLine("Exit AddFirst AddLast AddAtPosition Print");
                }

                WriteLine("Введите доступную команду в строку: ");
                string EnterWord = ReadLine();


                if (EnterWord == KeyExit)
                    Environment.Exit(0);
                if (EnterWord == KeyAddF)
                {
                    WriteLine("Введите значение: ");
                    string Enter = ReadLine();
                    list.AddFirst(Enter);
                    WriteLine("******************************************");
                }
                if (EnterWord == KeyAddL)
                {
                    WriteLine("Введите значение: ");
                    string Enter = ReadLine();
                    list.AddLast(Enter);
                    WriteLine("******************************************");
                }
                if (EnterWord == KeyAddP)
                {
                    WriteLine("Введите значение: ");
                    string Enter = ReadLine();
                    WriteLine("Введите позицию: ");
                    int Pos = Int32.Parse(ReadLine());
                    //list.AddToPosition(Enter, pos);
                }
                if (EnterWord == KeyDelF)
                {
                    WriteLine("Введите значение: ");
                    string Enter = ReadLine();
                    list.RemoveFirst();
                    WriteLine("******************************************");
                }
                if (EnterWord == KeyDelL)
                {
                    WriteLine("Введите значение: ");
                    string Enter = ReadLine();
                    list.RemoveLast();
                    WriteLine("******************************************");
                }
                if (EnterWord == KeyDelP)
                {
                    WriteLine("Введите позицию: ");
                    int Pos = Int32.Parse(ReadLine());
                    //list.DeleteFromPosition(Pos);
                }
                if (EnterWord == KeyPrin)
                {
                    if (list.Count != 0)
                    {
                        foreach (string s in list)
                        {
                            Write(s + " \n");
                        }
                    }
                    else
                    {
                        WriteLine("LinkedList не имеет значений!");
                    }

                    WriteLine("******************************************");
                }
                if (EnterWord == KeyNode)
                {
                    WriteLine("Введите значение: ");
                    string Enter = ReadLine();
                    int enter = Int32.Parse(Enter);
                    if (-21 < enter && enter <= 34)
                    {

                    }
                    WriteLine("******************************************");
                }
            }
        }
        catch
        {
            WriteLine("Извините, команда не доступна!");
        }

        Console.ReadLine();
        }
    }