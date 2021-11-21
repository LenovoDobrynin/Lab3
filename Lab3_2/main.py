def rotatematrix(m, rot90=1):
    if rot90 == 1:
        m = [list(t) for t in zip(*reversed(m))]
    return m
import numpy as np
m = np.matrix(np.random.randint(100, size=(int(input('Строки= ')), int(input('Столбцы= ')))))
print(m)
print('-----Поворот на 90 градусов---------')
print(np.rot90(m, k=1))