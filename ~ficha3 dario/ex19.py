n1=0
n2=1
prox=0
for i in range(1,61):
    prox=n1+n2
    n1=n2
    n2=prox
    print(prox)