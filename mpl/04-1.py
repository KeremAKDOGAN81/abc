import random

t = []
print(len(t))

for i in range(8):
    element = int(6 * random.random()) + 1
    t.append(element)

print(t)
# print(len(t))

print(t[::-1])
