/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
А В
1 4 | 3 5
3 5 | 1 2

Результирующая матрица будет:
С
7 13
14 25

Произведением двух матриц А и В называется матрица С, элемент которой, находящийся на пересечении i-й строки и j-го столбца, равен сумме произведений элементов i-й строки матрицы А на соответствующие (по порядку) элементы j-го столбца матрицы В.

С (0,0) = А(0,0) * B(0,0) + A(0,1) * B(1,0) = 1 · 3 + 4 · 1 = 3 + 4 = 7
С (0,1) = А(0,0) * B(0,1) + A(0,1) * B(1,1) = 1 · 5 + 4 · 2 = 5 + 8 = 13
С (1,0) = А(1,0) * B(0,0) + A(1,1) * B(1,0) = 3 · 3 + 5 · 1 = 9 + 5 = 14
С (1,1) = А(1,0) * B(0,1) + A(1,1) * B(1,1) = 3 · 5 + 5 · 2 = 15 + 10 = 25

Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В.

В произведении матриц АВ число строк равно числу строк матрицы А , а число столбцов равно числу столбцов матрицы В.*/



int[,] matrixA = new Int32[2, 2];
int[,] matrixB = new Int32[2, 2];
int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
/*
matrixA[0, 0] = 1;
matrixA[0, 1] = 4;
matrixA[1, 0] = 3;
matrixA[1, 1] = 5; 
matrixB[0, 0] = 3;
matrixB[0, 1] = 5;
matrixB[1, 0] = 1;
matrixB[1, 1] = 2; 
*/
randomFilling(matrixA, 1, 10);
randomFilling(matrixB, 1, 10);
arrayOutput(matrixA);
Console.WriteLine(" ");
arrayOutput(matrixB);
Console.WriteLine(" ");
arrayOutput(matrixMultiplication(matrixA, matrixB));

int[,] matrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

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
}