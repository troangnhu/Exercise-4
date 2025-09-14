using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. find the largest number of the three numbers");
            FindMax(3);
            Console.Write("1. (improve version) n = ");
            int findmax = int.Parse(Console.ReadLine());
            FindMax(findmax);

            Console.WriteLine("2. calculate the factorial of a number");
            Factorial();

            Console.WriteLine("3. check whether a number is prime");
            CheckPrime();

            Console.WriteLine("4. print prime numbers");
            PrintPrimes();

            Console.WriteLine("5. check perfect number");
            PerfectNumbers();

            Console.WriteLine("6. check pangram string");
            PangramCheck();
        }

        static void FindMax(int n)
        {
            float[] arr = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                arr[i] = float.Parse(Console.ReadLine());
            }

            float max = arr[0];
            for(int i = 0; i < n; i++)
            {
                if(arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine($"max = {max}\n");
        }

        static void Factorial ()
        {
            int n;
            do
            {
                Console.Write("n = ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n<0);

            int factorial = 1;
            for (int i = 2;i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"{n}! = {factorial}\n");
        }
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void CheckPrime()
        {
            int n;
            do
            {
                Console.Write("n = ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            Console.WriteLine(IsPrime(n) ? $"{n} is prime" : $"{n} is not prime\n");
            Console.WriteLine();
        }

        static void PrintPrimes()
        {
            Console.Write("Enter limit: ");
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine($"Prime numbers < {limit}:");
            for (int i = 2; i < limit; i++)
            {
                if (IsPrime(i)) Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.Write("Enter N (number of primes): ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"First {N} prime numbers:");
            int count = 0, num = 2;
            while (count < N)
            {
                if (IsPrime(num))
                {
                    Console.Write($"{num} ");
                    count++;
                }
                num++;
            }
            Console.WriteLine("\n");
        }

        static bool IsPerfect(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) sum += i;
            }
            return sum == n;
        }

        static void PerfectNumbers()
        {
            Console.Write("Enter a number to check: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPerfect(n) ? $"{n} is perfect" : $"{n} is not perfect");

            Console.WriteLine("Perfect numbers < 1000:");
            for (int i = 1; i < 1000; i++)
            {
                if (IsPerfect(i)) Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        static void PangramCheck()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine().ToLower();
            bool pangram = true;
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!s.Contains(c)) { pangram = false; break; }
            }
            Console.WriteLine(pangram ? "This is a pangram" : "This is not a pangram");
        }

        /*
    1.Write a C# function to find the largest number of the three numbers.
    -Improve the next version that accept at least 1 parameter. (varArg)
2.Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
3.Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
4.Write a C# function to print
    1.all prime numbers that less than a number (enter prompt keyboard).
    2.the first N prime numbers
5.Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
6.Write a C# function to check whether a string is a pangram or not.
(Note: Pangrams are words or sentences containing every letter of the alphabet at least once. For example: "The quick brown fox jumps over the lazy dog"
         */
    }
}
