using System;
    class Program
    {
        static void Main(string[] args)

        {

            Random rand = new Random(); 
            Console.WriteLine("количество элементов в массиве");
            int k = int.Parse(Console.ReadLine());
            int[] mas = new int[k];
            for (k = 0; k < mas.Length; k++)
            {
                mas[k] = rand.Next(-30, 45);
            }
            Console.WriteLine("Элементы массива");   
            int j = 0;
            foreach (int element in mas)
            {
                Console.Write(element + " \t");
                j++;
                while (j > 9)
                {
                    Console.WriteLine();
                    j = 0;
                }
            }
            Console.WriteLine();
            Console.Write("элементы в обратном порядке "); 
            Console.WriteLine();
            Array.Reverse(mas);
            foreach (int element in mas)
            {
                if (element > 0)
                {
                    Console.Write(element + " \t");
                    j++;
                    while (j > 9)
                    {
                        Console.WriteLine();
                        j = 0;
                    }
                }
            }

        }
        public static void Reverse(int[] mas) { }
    }
