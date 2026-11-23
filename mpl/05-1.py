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
