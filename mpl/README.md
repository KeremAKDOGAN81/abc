# Python Files
## 1. 01.py
This Python script demonstrates basic loop structures (`for` and `while`) and conditional divisibility checks using the modulo operator. It includes an inactive `for` loop (commented out inside a multi-line string) intended to print all multiples of 17 between 1 and 1000, followed by an active `while` loop that counts down from 100 in steps of 10 and prints numbers divisible by both 3 and 5 (`90 60 30`).
```python
"""
for i in range(1, 1001, 1):
    if i % 17 == 0 :
        print(i, end=" ")
"""

i = 100
while i > 0:
    if i % 3 == 0 and i % 5 == 0:
        print(i, end=" ")
    i = i - 10
```
## 2. 02.py
This Python script approximates the value of **Pi ($\pi$)** using the **Leibniz formula** ($1 - \frac{1}{3} + \frac{1}{5} - \frac{1}{7} + \dots = \frac{\pi}{4}$). It runs a `for` loop for 100,000 iterations, calculating each odd-denominator fraction (`terim`), alternating its sign between positive and negative (`sign *= -1`), and adding it to a running total before multiplying the final sum by 4 to print the result (`~3.14158`).
```python
total = 0
sign = 1

for n in range(100000):
    terim = 1 / (2 * n + 1)
    total += sign * terim
    sign *= -1
pi_approximately = 4 * total
print(pi_approximately)
```
## 3. 03.py
This Python script compares the convergence speed and accuracy of two mathematical series used to approximate **Pi ($\pi$)**: the **Leibniz formula** and the **Euler (Basel) series** ($\sum \frac{1}{n^2} = \frac{\pi^2}{6}$). After printing the results of both methods at 1,000 iterations, it uses `while` loops to calculate and display the exact number of iterations each algorithm requires to reach an accuracy within `0.001` of the true value of $\pi$, highlighting Euler's faster convergence.
```python
acurate_pi = 3.141592653589


# Leibnitz
def leibnitz(n):
    pi = 0
    sign = -1
    for i in range(n + 1):
        sign *= -1
        # print(sign * 1 / (2 * i + 1))
        pi += sign * 1 / (2 * i + 1)
    return 4 * pi


# print(f" n=10, pi = {leibnitz(10)}")
# print(f" n=1000, pi = {leibnitz(1000)}")
# print(leibnitz(1000) - accurate_pi)


# Euler
def euler(n):
    pi = 0
    for i in range(1, n + 1):
        # print(1 / (i * i))
        pi += 1 / (i * i)
    return (6 * pi) ** 0.5


print(leibnitz(1000), euler(1000))

diff = 0.001
i = 1
while abs(leibnitz(i) - acurate_pi) > diff:
    i += 1
print("Leibnitz", i, diff, leibnitz(i))

i = 1
while abs(euler(i) - acurate_pi) > diff:
    i += 1
print("Euler", i, diff, euler(i))
```
## 4. 04-1.py
This Python script demonstrates how to create and modify a list. It starts with an empty list and prints its length (`0`), then generates eight random integers from 1 to 6 and appends them to the list. It prints the resulting list and uses slice notation (`[::-1]`) to print the same elements in reverse order. The commented-out `print(len(t))` line would print the list's length after the eight values have been added.
```python
import random

t = []
print(len(t))

for i in range(8):
    element = int(6 * random.random()) + 1
    t.append(element)

print(t)
# print(len(t))

print(t[::-1])
```
## 5. 04-2.py
This Python script simulates rolling three six-sided dice 100,000 times and counts how often each possible total (from 3 to 18) occurs. The list `t` stores one count for each total; `rst - 3` converts a dice total to its corresponding list index. The final loop prints each possible total alongside its frequency.
```python
import random


def main():
    random_gen = random.Random()

    t = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]

    for j in range(100000):
        dice1 = random_gen.randint(1, 6)
        dice2 = random_gen.randint(1, 6)
        dice3 = random_gen.randint(1, 6)

        rst = dice1 + dice2 + dice3
        t[rst - 3] += 1

    for i in range(len(t)):
        print(i + 3, t[i])


if __name__ == "__main__":
    main()
```
## 6. 04-3.py
This Python script chooses a secret integer between 1 and 100 and repeatedly asks the user to guess it. It prints `"Too small"` or `"Too big"` when a guess is incorrect. However, when the guess is correct, neither condition runs and the `while True` loop does not stop, so the final `print(secret_num)` statement is never reached.
```python
import random

secret_num = random.randint(1, 100)
guess = 0

while True:
    guess = int(input("Try to guess: "))
    if guess < secret_num:
        print("Too small")
    elif guess > secret_num:
        print("Too big")

print(secret_num)
```

## 7. 05.py
This Python script compares three mathematical methods for approximating Pi (`π`) and plots their convergence over 50 iterations using Matplotlib. The Leibniz series is implemented by `leibnitz(n)`, the Euler/Basel series by `euler(n)`, and the Wallis product by `wallis(n)`. The resulting estimates are rounded to two decimal places and displayed on a line chart in red, blue, and green, respectively, with a black reference line for `Pi = 3.14`.
```python
import matplotlib.pyplot as plt


def leibnitz(n):
    L = []
    X = []
    Z = []
    s = 0
    for i in range(1, n + 1):
        s = s + 1.0 * (-1) ** (i + 1) * 4 / (2 * i - 1)
        X.append(i)
        L.append(round(s, 2))
        Z.append(3.14)
    return X, L, Z


def euler(n):
    E = []
    total = 0
    part = 0
    pi = 0
    for i in range(1, n + 1):
        part = 1.0 / (i * i)
        total += part
        pi = total * 6
        pi = pi ** (0.5)
        E.append(round(pi, 2))
    return E


def wallis(n):
    W = []
    pi = 1.0
    for i in range(1, n + 1):
        pi *= (2.0 * i) / (2.0 * i - 1) * (2.0 * i) / (2.0 * i + 1)
        W.append(round(pi * 2, 2))
    return W


rep = 50
X, L, Z = leibnitz(rep)
E = euler(rep)
W = wallis(rep)

plt.style.use("ggplot")
fig, ax = plt.subplots()
ax.plot(L, c="red", label="Leibnitz")
ax.plot(E, c="blue", label="Euler")
ax.plot(W, c="green", label="Wallis")
ax.plot(Z, c="black", label="Pi = 3.14")

ax.set_title("Aproaching to number PI", fontsize=12)
ax.set_xlabel("Number of iterrations: " + str(rep), fontsize=10)
ax.set_ylabel("Value of PI", fontsize=10)
plt.legend(bbox_to_anchor=(1, 1), ncol=1)
plt.show()
```


