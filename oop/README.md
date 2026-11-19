# C# Files

## 1. Calculation of Pi

A C# console app with two parts: approximating π with three different series, and simulating dice rolls.

### Approximating π

| Method | Idea | Function |
|---|---|---|
| Leibniz | π/4 = 1 − 1/3 + 1/5 − 1/7 + … | `Leibnitz(n)` |
| Euler | π²/6 = 1 + 1/2² + 1/3² + … | `Euler(n)` |
| Wallis | π/2 = (2/1 · 2/3) · (4/3 · 4/5) · … | `Wallis(n)` |

`n` is the number of terms. The program prints each result for `n = 1000`, then finds how many terms each method needs to get within 0.001 of the real value of π. This shows which method converges fastest.

### Dice simulation

Two six-sided dice are rolled 100,000 times with `Random`. The program counts how often each total (2-12) occurs and prints the counts. Totals near 7 appear most often because more dice combinations produce them, while 2 and 12 are the rarest.

### Code

```csharp
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
```

## 2. Prime Numbers

A C# console app that finds all prime numbers in a given range and counts them.

| Function | What it does |
|---|---|
| `prime(a, b)` | Checks if `a` is prime by trying to divide it by every number from 2 to `a − 1` |
| `howManyPrimes(a, b)` | Counts the primes between `a` and `b` (inclusive) |

The range is set in `Main` with `start = 1` and `finish = 100000`. The program prints every prime it finds, then prints the total, for example `Between 1 and 100000: 9592 primes`.

This uses simple trial division, so it is easy to read but slow for large ranges. It could be made faster by only testing divisors up to √a, or by using the Sieve of Eratosthenes.

### Code

```csharp
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
```