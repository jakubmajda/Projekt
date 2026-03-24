print("Podaj liczbe stopni:")
degrees = float(input())

print("Wybierz skale w ktorej sa twoje stopnie:")
print("1 - Stopnie C")
print("2 - Stopnie F")
action = int(input())
if action==1:
    print("Wartosc po konwersji na F:")
    print(degrees * 1.8 + 32)

elif action==2:
    print("Wartosc po konwersji na C:")
    print((degrees - 32) / 1.8)