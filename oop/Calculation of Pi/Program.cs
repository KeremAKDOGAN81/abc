namespace Calculation_of_Pi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double accurate_pi = 3.141592653589;

            Console.WriteLine($"{Leibnitz(1000)} {Euler(1000)} {Wallis(1000)}");

            double diff = 0.001;
            int i = 1;
            while (Math.Abs(Leibnitz(i) - accurate_pi) > diff)
            {
                i++;
            }
            Console.WriteLine($"Leibnitz {i} {diff} {Leibnitz(i)}");

            i = 1;
            while (Math.Abs(Euler(i) - accurate_pi) > diff)
            {
                i++;
            }
            Console.WriteLine($"Euler {i} {diff} {Euler(i)}");

            i = 1;
            while (Math.Abs(Wallis(i) - accurate_pi) > diff)
            {
                i++;
            }
            Console.WriteLine($"Wallis {i} {diff} {Wallis(i)}");

            Random random = new Random();

            int rst = 0;
            int o2 = 0;
            int o3 = 0;
            int o4 = 0;
            int o5 = 0;
            int o6 = 0;
            int o7 = 0;
            int o8 = 0;
            int o9 = 0;
            int o10 = 0;
            int o11 = 0;
            int o12 = 0;


            for (int j = 0; j < 100000; j++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                rst = dice1 + dice2;

                if (rst == 2)
                {
                    o2++;

                }
                if (rst == 3)
                {
                    o3++;
                }
                if (rst == 4)
                {
                    o4++;
                }
                if (rst == 5)
                {
                    o5++;
                }
                if (rst == 6)
                {
                    o6++;
                }
                if (rst == 7)
                {
                    o7++;
                }
                if (rst == 8)
                {
                    o8++;
                }
                if (rst == 9)
                {
                    o9++;
                }
                if (rst == 10)
                {
                    o10++;
                }
                if (rst == 11)
                {
                    o11++;
                }
                if (rst == 12)
                {
                    o12++;
                }
            }//end of the loop
            Console.WriteLine("2: " + o2);
            Console.WriteLine("3: " + o3);
            Console.WriteLine("4: " + o4);
            Console.WriteLine("5: " + o5);
            Console.WriteLine("6: " + o6);
            Console.WriteLine("7: " + o7);
            Console.WriteLine("8: " + o8);
            Console.WriteLine("9: " + o9);
            Console.WriteLine("10: " + o10);
            Console.WriteLine("11: " + o11);
            Console.WriteLine("12: " + o12);
        }


        public static double Leibnitz(int n)
        {
            double pi = 0;
            int sign = -1;

            for (int i = 0; i <= n; i++)
            {
                sign *= -1;
                pi += sign * 1.0 / (2 * i + 1);

            }

            return 4 * pi;
        }

        public static double Euler(int n)
        {
            double pi = 0;
            for (int i = 1; i <= n; i++)
            {
                pi += 1.0 / ((double)i * i);
            }
            return Math.Sqrt(6 * pi);
        }

        public static double Wallis(int n)
        {
            double pi = 1;
            for (int i = 1; i <= n; i++)
            {
                pi *= (2.0 * i) / (2.0 * i - 1) * (2.0 * i) / (2.0 * i + 1);
            }
            return pi * 2;
        }

    }
}