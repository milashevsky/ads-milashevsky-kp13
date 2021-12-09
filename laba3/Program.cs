using System;
using System.Collections.Generic;
using static System.Console;

namespace SortHutsuliak
{
    class Program
    {

        static void Main(string[] args)
        {
            int temp = 0;
            Random rnd = new Random();
            WriteLine("Введiть кiлькiсть елементiв масиву: ");
            int n = Int32.Parse(ReadLine());
            int[] array = new int[n];
            WriteLine("Початковий масив елементiв: ");
            for (int z = 0; z < n; z++)
            {
                array[z] = rnd.Next(0, 100000);
                Write(array[z] + " ");
            }

            Zmenshen(array, temp, n);

            var array1 = Array.ConvertAll(array, x => x.ToString());

            List<string> one = new List<string>();
            List<string> two = new List<string>();
            List<string> thr = new List<string>();
            List<string> fou = new List<string>();
            List<string> fiv = new List<string>();
            List<string> six = new List<string>();
            List<string> sev = new List<string>();
            List<string> eig = new List<string>();
            List<string> nin = new List<string>();
            List<string> ten = new List<string>();


            for (int i = 0; i < n; i++)
            {
                if (array1[i].Length == 10)
                {
                    ten.Add(array1[i]);
                }
                else if (array1[i].Length == 9)
                {
                    nin.Add(array1[i]);
                }
                else if (array1[i].Length == 8)
                {
                    eig.Add(array1[i]);
                }
                else if (array1[i].Length == 7)
                {
                    sev.Add(array1[i]);
                }
                else if (array1[i].Length == 6)
                {
                    six.Add(array1[i]);
                }
                else if (array1[i].Length == 5)
                {
                    fiv.Add(array1[i]);
                }
                else if (array1[i].Length == 4)
                {
                    fou.Add(array1[i]);
                }
                else if (array1[i].Length == 3)
                {
                    thr.Add(array1[i]);
                }
                else if (array1[i].Length == 2)
                {
                    two.Add(array1[i]);
                }
                else if (array1[i].Length == 1)
                {
                    one.Add(array1[i]);
                }
            }

            string[] arrayone = one.ToArray();
            string[] arraytwo = two.ToArray();
            string[] arraythr = thr.ToArray();
            string[] arrayfou = fou.ToArray();
            string[] arrayfiv = fiv.ToArray();
            string[] arraysix = six.ToArray();
            string[] arraysev = sev.ToArray();
            string[] arrayeig = eig.ToArray();
            string[] arraynin = nin.ToArray();
            string[] arrayten = ten.ToArray();


            int[] array11 = Array.ConvertAll(arrayone, s => int.Parse(s));
            int[] array12 = Array.ConvertAll(arraytwo, s => int.Parse(s));
            int[] array13 = Array.ConvertAll(arraythr, s => int.Parse(s));
            int[] array14 = Array.ConvertAll(arrayfou, s => int.Parse(s));
            int[] array15 = Array.ConvertAll(arrayfiv, s => int.Parse(s));
            int[] array16 = Array.ConvertAll(arraysix, s => int.Parse(s));
            int[] array17 = Array.ConvertAll(arraysev, s => int.Parse(s));
            int[] array18 = Array.ConvertAll(arrayeig, s => int.Parse(s));
            int[] array19 = Array.ConvertAll(arraynin, s => int.Parse(s));
            int[] array110 = Array.ConvertAll(arrayten, s => int.Parse(s));


            Zbilshen(array11, temp, array11.Length);
            Zbilshen(array12, temp, array12.Length);
            Zbilshen(array13, temp, array13.Length);
            Zbilshen(array14, temp, array14.Length);
            Zbilshen(array15, temp, array15.Length);
            Zbilshen(array16, temp, array16.Length);
            Zbilshen(array17, temp, array17.Length);
            Zbilshen(array18, temp, array18.Length);
            Zbilshen(array19, temp, array19.Length);
            Zbilshen(array110, temp, array110.Length);


            PrintResult(array11,array12,array13, array14, array15, array16, array17, array18, array19, array110);
        }

        static int[] Zmenshen(int[] array, int temp, int n)
        {
            bool flag = true;

            while (flag)
            {
                flag = false;
                for (int j = 0; j < n - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {

                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = true;
                    }

                }
            }

            WriteLine();
            WriteLine("Масив пiсля першого (1) сортування: ");
            for (int j = 0; j < n; j++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Write(array[j] + " ");
                Console.ResetColor();
            }

            return array;
        }

        static int[] Zbilshen(int[] array, int temp, int n)
        {
            bool flag1 = true;

            while (flag1)
            {
                flag1 = false;
                for (int j = 0; j < n - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {

                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag1 = true;
                    }

                }
            }

            return array;
        }
        static void PrintResult(int[] array11, int[] array12, int[] array13, int[] array14, int[] array15, int[] array16, int[] array17, int[] array18, int[] array19, int[] array110)
        {
            WriteLine();
            WriteLine("Масив пiсля другого (2) сортування: ");
            for (int j = 0; j < array110.Length; j++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Write(array110[j] + " ");
                Console.ResetColor();
            }
            for (int j = 0; j < array19.Length; j++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Write(array19[j] + " ");
                Console.ResetColor();
            }
            for (int j = 0; j < array18.Length; j++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Write(array18[j] + " ");
                Console.ResetColor();
            }
            for (int j = 0; j < array17.Length; j++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Write(array17[j] + " ");
                Console.ResetColor();
            }
            for (int j = 0; j < array16.Length; j++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Write(array16[j] + " ");
                Console.ResetColor();
            }
            for (int j = 0; j < array15.Length; j++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Write(array15[j] + " ");
                Console.ResetColor();
            }
            for (int j = 0; j < array14.Length; j++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Write(array14[j] + " ");
                Console.ResetColor();
            }
            for (int j = 0; j < array13.Length; j++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Write(array13[j] + " ");
                Console.ResetColor();
            }

            for (int j = 0; j < array12.Length; j++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Write(array12[j] + " ");
                Console.ResetColor();
            }

            for (int j = 0; j < array11.Length; j++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Write(array11[j] + " ");
                Console.ResetColor();
            }
        }
    }
}
