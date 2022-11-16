/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f2}\t");
        }
        Console.WriteLine();
    }
}
double[,] CreateRandomMatrix(int rows, int columns, int minLimitRandom, int maxLimitRandom)
{
    var random = new Random();
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(minLimitRandom, maxLimitRandom + 1) + random.NextDouble();
        }
    }
    return matrix;
}
int rows = Prompt("Введите количество строк в матрице : ");
int columns = Prompt("Введите количество колонок в матрице : ");
int minRandomLimit = Prompt("Введите минимальную границу случайных чисел : ");
int maxRandomLimit = Prompt("Введите максимальную границу случайных чисел : ");
double[,] array = CreateRandomMatrix(rows, columns, minRandomLimit, maxRandomLimit);
PrintArray(array);