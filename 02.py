total = 0
sign = 1

for n in range(100000):
    terim = 1 / (2 * n + 1)
    total += sign * terim
    sign *= -1
pi_approximately = 4 * total
print(pi_approximately)
