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
