total=0
med=0.0
for i in range(0,10):
    nota=int(input(f"Insira a {i} nota: "))
    total=total+nota
    
med=total/10
print(f"A media do aluno é de {med}")