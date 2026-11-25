import matplotlib.pyplot as plt
import numpy as np

countries = ("United States", "China", "Japan", "Australia", "France")

medal_data = {
    'Bronze': (42, 24, 13, 16, 22),
    'Silver': (44, 27, 12, 19, 26),
    'Gold': (40, 40, 20, 18, 16),
    'Total': (126, 91, 45, 53, 64)
}

x = np.arange(len(countries))
width = 0.20
multiplier = 0

fig, ax = plt.subplots(figsize=(10, 6), layout='constrained')

for medal_type, counts in medal_data.items():
    offset = width * multiplier
    rects = ax.bar(x + offset, counts, width, label=medal_type)
    ax.bar_label(rects, padding=3, fontsize=9)
    multiplier += 1

ax.set_ylabel('Number of Medals')
ax.set_title('Top 5 Nations by Medals (Paris 2024)')
ax.set_xticks(x + width * 1.5)
ax.set_xticklabels(countries)
ax.legend(loc='upper right')
ax.set_ylim(0, 140)

plt.show()