def fibonacci(n):
    if n in (1, 2):
        return 1
    return fibonacci(n - 1) + fibonacci(n - 2)
n = int(input('Введите член ряда Фибоначчи: '))
print(fibonacci(n))