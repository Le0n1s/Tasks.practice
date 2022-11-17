/*Задача 54.1 : Задайте двумерный массив. Напишите программу, которая упорядочит элементы по убыванию (или возрастанию).*/

int line = 5;
int column = 4;
int[,] array = new Int32[line, column];

randomFilling(array, 0, 10);
Console.WriteLine("Not sort");
arrayOutput(array);
int[] tempArray = array.Cast<int>().ToArray();
printArray(tempArray);
Array.Sort(tempArray);
printArray(tempArray);
fill2Darray(array, tempArray);
Console.WriteLine("Sort");
arrayOutput(array);

void randomFilling(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
}

void fill2Darray(int[,] arr, int[] arr2)
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = arr2[column * i + j];
        }
    }
}


void arrayOutput(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }

        Console.WriteLine(" ");
    }
    Console.WriteLine(" ");
}

void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < (arr.Length - 1)) Console.Write($", ");

    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}