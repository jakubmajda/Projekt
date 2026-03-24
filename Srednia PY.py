print("Podaj liczbe ocen:")
grades = float(input())
avg = 0

for i in range(int(grades)):
    print("Podaj ocene:")
    avg = avg + float(input())

avg = avg / grades
print("Srednia ocen:")
print(avg)

if avg<3:
    print("Nie zdales")

elif avg>3:
    print("Zdales")