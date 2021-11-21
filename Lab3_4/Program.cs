using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 3];
            Random rand = new Random();
            Console.WriteLine("Первый массив: ");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = rand.Next(1, 10);
                    Console.Write(" " + myArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ");

            int[,] myArray2 = new int[3, 3];
            Console.WriteLine("Второй массив: ");
            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    myArray2[i, j] = rand.Next(1, 10);
                    Console.Write(" " + myArray2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ");
            Console.WriteLine("Необходимое действие: '+','-' или 'Sred' (Среднее значение): ");
            string opt = Console.ReadLine();
           
 switch (opt)
            {
                case "+":
                    Console.WriteLine("Сумма массивов: ");
                    int[,] Sum = new int[3, 3];
                    for (int i = 0; i < Sum.GetLength(0); i++)
                    {
                        for (int j = 0; j < Sum.GetLength(1); j++)
                        {
                            Sum[i, j] = myArray[i, j] + myArray2[i, j];
                            Console.Write("  " + Sum[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine(" ");
                    break;
                case "-":
                    Console.WriteLine("Разность массивов: ");
                    int[,] Dif = new int[3, 3];
                    for (int i = 0; i < Dif.GetLength(0); i++)
                    {
                        for (int j = 0; j < Dif.GetLength(1); j++)
                        {
                            Dif[i, j] = myArray[i, j] - myArray2[i, j];
                            Console.Write("  " + Dif[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine(" ");
                    break;
                case "Sred":
                    Console.WriteLine("Среднее значение массивов: ");
                    int[,] Sr = new int[3, 3];
                    for (int i = 0; i < Sr.GetLength(0); i++)
                    {
                        for (int j = 0; j < Sr.GetLength(1); j++)
                        {
                            Sr[i, j] = (myArray[i, j] + myArray2[i, j]) / 2;
                            Console.Write("  " + Sr[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine(" ");
                    break;
                default:
                    Console.WriteLine("Ошибка во вводе");
                    break;
            }
        }
    }