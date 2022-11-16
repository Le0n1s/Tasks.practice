﻿/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

[1,7] -> такого элемента в массиве нет*/

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void PrintArray(int[,] matrix)
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
bool ValidatePosition(int[,] matrix, int rowPosition, int columnPosition)
{
    if ((rowPosition) > 0
        && (rowPosition) <= matrix.GetLength(0)
        && (columnPosition) > 0
        && (columnPosition) <= matrix.GetLength(1))
    {
        return true;
    }
    return false;
}
int FindNumberByPositions(int[,] matrix, int rowPosition, int columnPosition)
{
    return matrix[rowPosition - 1, columnPosition - 1];
}
int rows = Prompt("Введите количество строк в матрице : ");
int columns = Prompt("Введите количество колонок в матрице : ");
int minRandomLimit = Prompt("Введите минимальную границу случайных чисел : ");
int maxRandomLimit = Prompt("Введите максимальную границу случайных чисел : ");
int[,] array = CreateRandomMatrix(rows, columns, minRandomLimit, maxRandomLimit);
PrintArray(array);
int rowPosition = Prompt("Введите номер строки : ");
int columnPosition = Prompt("Введите номер колонки : ");
if (ValidatePosition(array, rowPosition, columnPosition))
{
    Console.WriteLine($"Элемент в позиции {rowPosition}, {columnPosition} равен {FindNumberByPositions(array, rowPosition, columnPosition)}");
}
else
{
    Console.WriteLine("Такого элемента нет");
}