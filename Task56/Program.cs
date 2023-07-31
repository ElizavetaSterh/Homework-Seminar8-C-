// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

void FindRowSmallestSum(int[,] array)
{
    int minSum = 0;
    int rowMinSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) minSum = sum;
        if (sum < minSum)
        {
            minSum = sum;
            rowMinSum = i;
        }
        
    }
    Console.Write($"Cтроки с наименьшей суммой элементов: {rowMinSum + 1} строка.");
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
int m = GetInput("Введите количество строк: ");
int n = GetInput("Введите количество столбцов: ");
int[,] massive = Create2dMassive(m, n, 1, 100);
Print2dMassive(massive);
FindRowSmallestSum(massive);