def shift(lst, steps):
    if steps < 0:
        steps = abs(steps)
        for i in range(steps):
            lst.append(lst.pop(0))
    else:
        for i in range(steps):
            lst.insert(0, lst.pop())

nums = [4, 5, 6, 7, 8, 9, 0]
print(nums)
steps = int(input('На сколько хотим сместить? '))
shift(nums, -steps)
print(nums)