using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace asd2
{
    class Program
    {
        static void Main()
        {
            try
            {
                Random random = new Random();

                Console.Write("Введите размер квадратной матрицы: ");
                int r = Convert.ToInt16(Console.ReadLine());
                
                int[,] Matriy = new int[r, r];
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < r; j++)
                    {
                        Matriy[i, j] = random.Next(0, 100);
                    }
                }

                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < r; j++)
                    {
                        Console.Write(Matriy[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                int[] Result = new int[r * r];

                List<int> nad = new List<int>();
                List<int> pod = new List<int>();


                int y = 0, x = r - 2;

                Console.WriteLine("ResultArray:");

                for (int i = 0; i < r * r; i++)
                {
                    Result[i] = Matriy[y, x];
                    Console.Write(Result[i] + "[" + x + "][" + y + "]");

                    if (x + y < r - 1)
                    {
                        nad.Add(Matriy[y, x]);
                        if (x % 2 == 0)
                        {
                            if (x + y == r - 2)
                            {
                                if (x != 0)
                                {
                                    x = x - 1;
                                    y = y + 1;
                                }
                                else
                                {
                                    y = y + 1;
                                }
                            }
                            else
                            {
                                y = y + 1;
                            }
                        }
                        else
                        {
                            if (y == 0)
                            {
                                x = x - 1;
                            }
                            else
                            {
                                y = y - 1;
                            }
                        }
                    }
                    else
                    {
                        if (x + y == r - 1)
                        {
                            pod.Add(Matriy[y, x]);
                            if (y == 0)
                            {
                                y = y + 1;
                            }
                            else
                            {
                                y = y - 1;
                                x = x + 1;
                            }
                        }
                        else
                        {
                            if (y % 2 == 0)
                            {
                                if (x == r - 1)
                                {
                                    y = y + 1;
                                }
                                else
                                {
                                    x = x + 1;
                                }
                            }
                            else
                            {
                                if (x + y == r)
                                {
                                    x = x - 1;
                                    y = y + 1;
                                }
                                else
                                {
                                    x = x - 1;
                                }
                            }
                        }
                    }
                    if (x + y < r - 1)
                    {
                        WriteLine(" - над побiчною дiагоналлю" + "\n");

                    }
                    else if (x + y > r - 1)
                    {
                        WriteLine(" - пiд побiчною дiагоналлю" + "\n");

                    }
                    else
                    {
                        WriteLine(" - побiчна дiагональ" + "\n");
                    }
                }

                int[] pod1 = pod.ToArray<int>();
                int[] nad1 = nad.ToArray<int>();

                int max_nad = nad1.Max();
                int min_nad = nad1.Min();
                int max_pod = pod1.Max();
                int min_pod = pod1.Min();

                WriteLine("Maximum value above the side diagonal: " + max_nad + "\n" + "Minimum value above the side diagonal: " + min_nad + "\n" + "Maximum value below the side diagonal: " + max_pod + "\n" + "Minimum value below the side diagonal: " + min_pod);

                Console.ReadKey();
            }
            catch
            {
                WriteLine("Помилка введення даних");
            }
        }
    }
}