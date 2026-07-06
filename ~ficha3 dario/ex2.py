
for i in range(1,10):
    num=int(input(f"Indique o {i} numero que deseja verificar: "))
    if num%2==0:
        print(f"O numero {i} é par.")
    elif num%2!=0:
        print(f"O numero {i} é impar")