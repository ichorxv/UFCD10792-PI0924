num = int(input("Digita um numero: "))
perf = 0

for i in range(1, num + 1):
    soma = 0
    for j in range(1, i):
        if i % j == 0:
            soma += j
    if soma == i:
        perf += 1

print(f"Existem {perf} números perfeitos até {num}.")