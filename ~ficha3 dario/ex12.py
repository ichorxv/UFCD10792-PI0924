
num=int(input("Quantos numeros queres fazer a soma, subtração, multiplicação e divisão: "))
cont=0

for i in range(1, num+1):
    
    print(f"Volta {i}")
    print()
    
    print(f"subtração: {num-i}")
    print(f"Soma: {num+i}")
    print(f"Multiplicação: {num*i}")
    print(f"Divisão: {num/i}")
    print("-"*20)
    cont+4
    
print(f"houve {cont} operações ")