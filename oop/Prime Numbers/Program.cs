namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int finish = 100000;
            for (int i = start; i <= finish; i++)
            {
                if (prime(i, finish) == true)
                {
                    Console.WriteLine(i + ", ");
                }
            }
            Console.WriteLine("Between {0} and {1}: {2} primes", start, finish, howManyPrimes(start, finish));
        }
        public static bool prime(int a, int b)
        {
            if (a <= 1)
            {
                return false;
            }
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int howManyPrimes(int a, int b)
        {

            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (prime(i, b) == true)
                {
                    count++;
                }
            }
            return count;
        }



    }
}
