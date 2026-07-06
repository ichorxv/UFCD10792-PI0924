

for i in range(0,256):
    print(i)
    print(chr(i))
    if i%20==0:
        rsp=input("queres continuar?")
        if rsp=="n":
            break
        