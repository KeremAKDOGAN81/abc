# Python Files
1. 01.py
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
2. 02.py
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
=======
total = 0
sign = 1

for n in range(100000):
    terim = 1 / (2 * n + 1)
    total += sign * terim
    sign *= -1
pi_approximately = 4 * total
print(pi_approximately)
```
3. 03.py
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
=======
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