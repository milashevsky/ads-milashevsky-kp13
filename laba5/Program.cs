using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using static System.Console;

namespace Radix_Sort
{
    class Program
    {
        static void Sort(long[] arr)
        {
            int i, j;
            long[] tmp = new long[arr.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }
        }
        static string SplitStr(string str, int maxSymbols)
        {
            var sb = new StringBuilder();
            var counter = 0;
            foreach (var element in str)
            {
                if (counter == maxSymbols)
                {
                    sb.Append(" ");
                    counter = 0;
                }

                sb.Append(element);
                counter++;
            }
            return sb.ToString();
        }
        static void WW(List<long> array)
        {
            long[] array1 = new long[array.Count];
            List<long> L2022 = new List<long>();
            long min = 2022000000000000;
            long max = 2022999999999999;

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] >= min && array[i] <= max)
                {
                    L2022.Add(array[i]);
                }
                else
                {
                    array1[i] = array[i];
                }
            }

            long[] LL2022 = new long[L2022.Count];
            for (int i = 0; i < L2022.Count; i++)
            {
                LL2022[i] = L2022[i];
            }

            WriteLine("\nOriginal array : ");
            for (int i = 0; i < array.Count; i++)
            {
                WriteLine(" " + SplitStr(array[i].ToString(), 4));
            }

            WriteLine("\nSorted array : ");
            Sort(LL2022);
            for (int i = LL2022.Length; i > 0; i--)
            {
                WriteLine(" " + SplitStr(LL2022[i - 1].ToString(), 4));
            }

            WriteLine("_____________________");

            Sort(array1);
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != 0)
                {
                    WriteLine(" " + SplitStr(array1[i].ToString(), 4));
                }
            }
            WriteLine("\n");
        }
        static void Main(string[] args)
        {
            string command = "Enter";
            while (command != "End")
            {
                WriteLine("Enter one of the following keywords:");
                WriteLine("Example - enter control stock:");
                WriteLine("Enter - shuffles the row:");
                WriteLine("End - complete the program");
                command = ReadLine();

                if (command == "Enter")
                {
                    WriteLine("Enter numbers: \n When you finish typing, write the command 'Stop'");
                    List<long> array = new List<long>();
                    string x = "start";

                    while (x != "Stop")
                    {
                        x = ReadLine();
                        if (x == "Stop")
                        {
                            break;
                        }
                        else if (x.Length > 19 || x.Length <19)
                        {
                            WriteLine("Error");
                            break;
                        }

                        array.Add(long.Parse(x.Replace(" ", string.Empty)));
                    }
                    WW(array);
                }
                else if (command == "Example")
                {
                    List<long> array = new List<long>() { 2022000077778888, 9999999999999999, 7321765487609163, 1234567765431289, 2022563091629833, 9000836492908562, 2033315820946186, 2022892864009187 };                  
                    WW(array);
                }
                else if (command == "End")
                {
                    break;
                }
                else
                {
                    WriteLine("INPUT ERROR");
                }
            }
        }
    }
}