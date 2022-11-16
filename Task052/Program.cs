/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int[,] CreateRandomMatrix(int rows, int columns, int minLimitRandom, int maxLimitRandom)
{
    var random = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(minLimitRandom, maxLimitRandom + 1);
        }
    }
    return matrix;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f2}\t");
    }
    Console.WriteLine();
}
double[] CalcAverageInColumns(int[,] matrix)
{
    double[] averages = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        averages[i] = CalcAverageInOneColumn(matrix, i);
    }
    return averages;
}
double CalcAverageInOneColumn(int[,] matrix, int column)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, column];
    }
    return sum / matrix.GetLength(0);
}
int rows = Prompt("Введите количество строк в матрице : ");
int columns = Prompt("Введите количество колонок в матрице : ");
int minRandomLimit = Prompt("Введите минимальную границу случайных чисел : ");
int maxRandomLimit = Prompt("Введите максимальную границу случайных чисел : ");
int[,] array = CreateRandomMatrix(rows, columns, minRandomLimit, maxRandomLimit);
PrintMatrix(array);
Console.WriteLine("Средние значения:");
PrintArray(CalcAverageInColumns(array));