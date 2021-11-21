import numpy

row1 = int(input('Введите количество строк в 1 матрице: '))
col1 = int(input('Введите количество столбцов в 1 матрице: '))
row2 = int(input('Введите количество строк во 2 матрице: '))
col2 = int(input('Введите количество столбцов во 2 матрице: '))

array1 = numpy.arange(col1 * row1).reshape((row1, col1))
array2 = numpy.arange(col2 * row2).reshape((row2, col2))

print('1 матрица: ')
print(array1)
print('2 матрица: ')
print(array2)
print('умножение этих матриц: ')
print(array1 * array2)