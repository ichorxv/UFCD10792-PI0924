opc = input("Deseja obter os primeiros 30 numeros (P)ares ou (I)mpares?").lower()

if opc == "p":
    for i in range (0,30):
        if(i%2==0):
            print(i)

elif opc == "i":
    for i in range(0, 30):
        if(i%2!=0):
            print(i)