namespace BS23_first
{
    public class Sibling
    {
        public void Solution()
        {
            var testCase = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCase; i++)
            {
                long nthRound = int.Parse(Console.ReadLine());
                long sum = 0;
                for (int j = 1; j <= nthRound; j++)
                {
                    if ((j & (j - 1)) == 0)
                        sum -= j;
                    else
                        sum += j;
                }

                Console.WriteLine(sum);
            }
        }

        public void SolutionV2()
        {
            int testCase = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCase; i++)
            {
                long nthRound = int.Parse(Console.ReadLine());
                long sum = ((nthRound + 1) * nthRound) / 2 - 2;
               
                for (int j = 1; (long)Math.Pow(2, j) <= nthRound; j++)
                {
                    sum -= (long)Math.Pow(2, j + 1);
                }
                Console.WriteLine(sum);
            }

        }
    }
}
