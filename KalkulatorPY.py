print ("Podaj liczbe a:")
a = float(input())

print ("Podaj liczbe b:")
b = float(input())

print ("Podaj operacje:")
print("1 dla dodawania")
print("2 dla odejmowania")
print("3 dla mnożenia")
print("4 dla dzielenia")
operation = float(input())
if operation == 1:
    print("Wynik:")
    print(a+b)
    

elif operation == 2:
    print("Wynik:")
    print(a - b)

elif operation == 3:
    print("Wynik:")
    print(a * b)

elif operation == 4:
    if(b!=0):
        print("Wynik:")
        print(a / b)
    else:
        print("Nie dziel przez 0")
