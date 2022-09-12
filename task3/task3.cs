// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

Random rnd = new Random();
int lines = rnd.Next(3, 6);
int columns = rnd.Next(3, 6);
double[,] arr = new double[lines, columns];
double[] avgs = new double[columns];

for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr[i, j] = rnd.Next(1, 10);
        avgs[j] += Convert.ToDouble(arr[i, j]) / lines;
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("_______________________________________________");

foreach (double elem in avgs)
{
    Console.Write(Math.Round(elem, 2) + "\t");
}