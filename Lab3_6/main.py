##итерационно вычислить сумму элементов массива
numbers = [2, 3, 4, -5]
numbers_sum = sum(numbers)
print(numbers_sum)


##рекурсивно вычислить сумму элементов массива
def sum_arr(arr, size):
    if (size == 0):
        return 0
    else:
        return arr[size - 1] + sum_arr(arr, size - 1)
n = int(input("Введите длину списка:"))
a = []
for i in range(0, n):
    element = int(input("Введите элемент списка:"))
    a.append(element)
print("Весь список:", a)
print("Сумма элементов списка равна:")
b = sum_arr(a, n)
print(b)


##итерационно вычислить минимальный элемент в массиве
list1 = [23,45,67,89]
print("минимальный : ", min(list1, default=0))


##рекурсивно вычислить минимальный элемент в массиве
def minimum(l, val):
  if not l[1:]:
     return val
  return minimum(l[1:], l[0] if l[0] < val else val)

l = [34, 23, 26, 4, 18]
print("минимальный : ",minimum(l, l[0]))