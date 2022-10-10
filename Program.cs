// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine()!);

PrintArray(RandomArray(m, n));

double[,] RandomArray(int m, int n)
{
    double[,] newArray = new double[m, n];
    Random randGenerator = new Random();
    for (int i = 0; i < m; i++) for (int j = 0; j < n; j++) newArray[i, j] = (double)randGenerator.Next(-100, 100)/10;
    return newArray;
}

void PrintArray(double[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++) Console.Write($"{newArray[i, j]}; ");
        Console.WriteLine("");
    }
}
