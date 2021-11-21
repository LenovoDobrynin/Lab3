n = int(input("Введите размер массива: "))
print('Введите элементы массива: ')
arr = []
for i in range(n):
    arr.append(int(input()))
d = arr[1] - arr[0]
i = 1
x = True
while x and (i < n):
    if arr[i] - arr[i-1] != d:
        x = False
        break
    i += 1
print(d if x else 'False')