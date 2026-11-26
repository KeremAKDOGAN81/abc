# Object-Oriented Programming

C# console exercises for the Object-Oriented Programming course.

| Exercise | Folder | Topics |
|---|---|---|
| [Calculation of Pi](#1-calculation-of-pi) | [`Calculation of Pi/`](Calculation%20of%20Pi/) | Series, convergence, random simulation |
| [Prime Numbers](#2-prime-numbers) | [`Prime Numbers/`](Prime%20Numbers/) | Trial division, loops, counting |
| [Student Case](#3-student-case) | [`Student Case/`](Student%20Case/) | Classes, constructors, arrays, object state |

## 1. Calculation of Pi

A C# console app that:

- Approximates pi using the Leibniz, Euler, and Wallis series.
- Prints the result of each method after 1,000 terms.
- Finds how many terms are needed for each method to get within `0.001` of `3.141592653589`.
- Simulates rolling two six-sided dice 100,000 times and counts each total from 2 through 12.

### Main methods

| Method | Purpose |
|---|---|
| `Leibnitz(int n)` | Approximates pi with the Leibniz series |
| `Euler(int n)` | Approximates pi with the Euler series |
| `Wallis(int n)` | Approximates pi with the Wallis product |

The exercise uses `Random.Next(1, 7)` for each die. Totals around 7 occur most frequently because they have more possible combinations.

## 2. Prime Numbers

A C# console app that checks the integers from `1` through `100000`, prints the prime numbers, and reports the total.

### Main methods

| Method | Purpose |
|---|---|
| `prime(int a, int b)` | Checks whether `a` is prime using trial division |
| `howManyPrimes(int a, int b)` | Counts primes in the inclusive range |

The current implementation tests divisors from `2` to `a - 1`. This is clear and suitable for a small exercise, but it can be made substantially faster with divisors only up to `sqrt(a)` or by using the Sieve of Eratosthenes.

Example output:

```text
2,
3,
5,
...
Between 1 and 100000: 9592 primes
```

## 3. Student Case

A C# console app that demonstrates basic object-oriented programming concepts with `Computer` and `Student` classes.

### Computer objects

The `Computer` class stores:

- BIOS name
- IP address
- Operating system

The program creates an array of computers and assigns generated IP addresses. It also replaces two entries with a server and a graphics station. The BIOS name and IP address of every computer are printed.

### Student objects

The `Student` class stores:

- Name
- Study age
- Faculty
- Student ID

The program creates students with parameterized constructors and also demonstrates a parameterless constructor followed by manually assigned fields. It prints all students, then filters and prints only students in Computer Programming.

### Concepts demonstrated

- User-defined classes
- Constructors
- Object arrays
- Public fields
- Reading object state
- Filtering objects
- Console output formatting

