// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void SelectionSort(int[,] massive)
{
    for (int row = 0; row < massive.GetLength(0); row++)
    {
        for (int colums = 0; colums < massive.GetLength(1) - 1; colums++)
        {
            int maxColums = colums;
            for (int j = colums + 1; colums < massive.GetLength(1) - 1; colums++)
            {
                if (massive[row, j] > massive[row, maxColums])
                    maxColums = j;
            }
            int temp = massive[row, colums];
            massive[row, colums] = massive[row, maxColums];
            massive[row, maxColums] = temp;
        }
    }
}

void Print2dMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)//строки
    {
        for (int j = 0; j < massive.GetLength(1); j++)//столбцы
        {
            Console.Write($"{massive[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
int[,] Create2dMassive(int rows, int colums, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int[,] massive = Create2dMassive(m, n, 1, 100);
Print2dMassive(massive);
Console.WriteLine();

SelectionSort(massive);
Print2dMassive(massive);