using System;
int[,] init = new int[9, 9];
for (int i = 0, k = 0, _ = 0; i - init.GetLength(0) - 1 < init.GetLength(1); k = (k == 0) ? ++i : --k)
{
    if (k < init.GetLength(0) && i - k < init.GetLength(1))
        init[k, i - k] = ++_;
    else if (k >= init.GetLength(0)) k = init.GetLength(0);
}
for (int i = 0; i < init.GetLength(0); i++)
{
    for (int j = 0; j < init.GetLength(1); j++) Console.Write(init[i, j] + " ");
    Console.WriteLine();
};
Console.ReadLine();