namespace BS23_first
{
    public class ATheBigInteger
    {
        public Int32 GetNthFibonacciNumber(int n)
        {
            if (n == 1)
                return 1;
            int number = n - 1; //Need to decrement by 1 since we are starting from 0  
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }

        public void Solution()
        {
            int testCase = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCase; i++)
            {
                var input = Console.ReadLine().Split(" ");
                var n = Convert.ToInt32(input[0]);
                var m = Convert.ToInt32(input[1]);

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
                        if(c%2 == 0)
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
