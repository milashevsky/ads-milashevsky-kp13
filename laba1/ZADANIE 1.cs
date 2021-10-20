using System;
using static System.Math;
using static System.Console;

namespace ZADANIE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("x = ");
                double x = double.Parse(ReadLine());
                WriteLine("y = ");
                double y = double.Parse(ReadLine());
                WriteLine("z = ");
                double z = double.Parse(ReadLine());
                double a, b;

                if (z != 0)
                {
                    a = Cos((x + x * y) / z);
                    if (Cos(a)!=0)
                    {
                        b = (x * x * x) / Cos(a);

                        WriteLine(a);
                        WriteLine(b);
                    }
                    else
                    {
                        WriteLine("Does not satisfy RAV");
                    }
                }
                else
                {
                    WriteLine("z =/= 0");
                }
            }
            catch
            {
                WriteLine("Incorrect data");
            }
        }
    }
}
