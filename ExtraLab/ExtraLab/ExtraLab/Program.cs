using System;

namespace ExtraLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №1");
            const int row = 4;
            const int column = 5;
            int[,] matrix = new int[column, row] { { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 9, 10, 11, 12 },
                    { 13, 14, 15, 16 },
                    { 17, 18, 19, 20 } };
            Task1 t1 = new Task1(matrix, row, column);
            matrix[0, 0] = t1.findMaxElement();
            Console.WriteLine(matrix[0,0]);

            Console.WriteLine("===========================================");

            Console.WriteLine("Задача №2");
            const int n = 5;
            int[,] matrix2 = new int[n, n] { { 5, 4, 3, 2, 1 },
                    { 4, 5, 4, 3, 2 },
                    { 3, 4, 5, 4, 3 }, 
                    { 2, 3, 4, 5, 4 },
                    { 1, 2, 3, 4, 5 } };
        
            Task2 t2 = new Task2(matrix2, n);
            if (t2.isSymmetric())
                Console.WriteLine("Симметрична");    
            else
                Console.WriteLine("Не симметрична");

            Console.WriteLine("===========================================");

            Console.WriteLine("Задача №3");
            int[,] matrix3 = new int[column, row] { { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 9, 10, 11, 12 },
                    { 13, 14, 15, 16 },
                    { 17, 18, 19, 20 } };
            Task3 t3 = new Task3(matrix3, row, column);
            int[,] newMatrix = t3.replace();
            Console.WriteLine(newMatrix[0, 0]);
            Console.WriteLine(newMatrix[4, 3]);
            Console.ReadLine();
        }
    }
}
