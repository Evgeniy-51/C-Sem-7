// Задача 2. Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

Random rnd = new Random();
int lines = rnd.Next(3, 9);
int col = rnd.Next(3, 9);
int[,] arr = new int[lines, col];

for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < col; j++)
    {
        arr[i, j] = rnd.Next(10);
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.Write("Введите строку:   ");
int linePos = Int32.Parse(Console.ReadLine()) - 1;
Console.Write("Введите столбец:  ");
int colPos = Int32.Parse(Console.ReadLine()) - 1;

Console.WriteLine((linePos <= lines && colPos <= col)
                    ? arr[linePos, colPos]
                    : "Нет такой позиции в массиве");

