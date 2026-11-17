# C# Files
1. Calculation of Pi
# Calculation of Pi

A C# console app with two parts: approximating π with three different series, and simulating dice rolls.

## 1. Approximating π

| Method | Idea | Function |
|---|---|---|
| Leibniz | π/4 = 1 − 1/3 + 1/5 − 1/7 + … | `Leibnitz(n)` |
| Euler | π²/6 = 1 + 1/2² + 1/3² + … | `Euler(n)` |
| Wallis | π/2 = (2/1 · 2/3) · (4/3 · 4/5) · … | `Wallis(n)` |

`n` is the number of terms. The program prints each result for `n = 1000`, then finds how many terms each method needs to get within 0.001 of the real value of π. This shows which method converges fastest.

## 2. Dice simulation

Two six-sided dice are rolled 100,000 times with `Random`. The program counts how often each total (2-12) occurs and prints the counts. Totals near 7 appear most often because more dice combinations produce them, while 2 and 12 are the rarest.

## Run

```
dotnet run
```