soma = 0
cont = 0

while cont < 30:
    num = int(input("Digita 30 numeros pares entre 1 e 50: "))
    if 1 <= num <= 50 and num % 2 == 0:
        soma += num
        cont += 1
    else:
        print("Numero inválido, Tem de ser par entre 1 e 50.")

media = soma / 30
print("Media dos 30 numeros pares:", media)