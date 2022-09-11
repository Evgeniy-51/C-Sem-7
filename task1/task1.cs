// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.

Console.Clear();

Console.Write("Введите число M:  ");
int m = Int32.Parse(Console.ReadLine());
Console.Write("Введите число N:  ");
int n = Int32.Parse(Console.ReadLine());

Random rnd = new Random();
double[,] arr = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = Math.Round(rnd.NextDouble() * 10, 2);
        System.Console.Write(arr[i, j] + "\t");
    }
    System.Console.WriteLine();
}


