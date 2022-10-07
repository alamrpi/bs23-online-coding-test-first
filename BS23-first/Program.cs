﻿using System;
namespace BS23_first
{
    public class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCase; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                int n = Convert.ToInt32(input[0]);
                int m = Convert.ToInt32(input[1]);

                int a = 0, b = 1, c = 0, oddNumber = 0, evenNumber = 0;

                if (n == 1)
                    evenNumber++;
                if (n == 2 || n == 1)
                    oddNumber++;

                for (int k = 3; k <= m; k++)
                {
                    c = a + b;
                    if (k >= n)
                    {
                        if (c % 2 == 0)
                            evenNumber++;
                        else
                            oddNumber++;
                    }

                    a = b;
                    b = c;

                }

                Console.WriteLine($"Case {i + 1}");
                Console.WriteLine($"Odd = {oddNumber}");
                Console.WriteLine($"Even = {evenNumber}");

            }

            Console.ReadKey();
        }
    }
}