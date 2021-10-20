using System;
using static System.Console;
class ZADANIE_2
{
            
    static void SieveOfEratosthenes(int n, bool[] prime)
    {
        try
        {
            for (int i = 0; i <= n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p] == true)
                {
                    for (int i = p * 2; i <= n; i += p)
                        prime[i] = false;
                }
            }
        }
        catch
        {
            WriteLine("Calculation Error");
        }
    }

    static void MersennePrimes(int n)
    {
        try
        {
            bool[] prime = new bool[n + 1];

            SieveOfEratosthenes(n, prime);

            for (int k = 1; ((1 << k) - 1) <= n; k++)
            {
                long num = (1 << k) - 1;

                if (prime[(int)(num)])
                    Write(num + " ");
            }
        }
        catch
        {
            WriteLine("Calculation Error");
        }
    }
    public static void Main()
    {
        try
        {
           Write("n = ");
           int n = int.Parse(ReadLine());
            if (n <= 0)
            {
                WriteLine("n must be natural");
            }
            else
            {
                WriteLine("Mersenne prime numbers" + " smaller than or equal to " + n);

                MersennePrimes(n);
            }
        }
        catch
        {
            WriteLine("Input Error");
        }
        
    }
   
}  