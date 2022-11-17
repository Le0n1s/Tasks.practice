/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/


int row = 4;
int col = 4;
int[,] array = new Int32[row, col];

snailFill(array);
arrayOutput(array);

void snailFill(int[,] arr)
{

    int s = 1;

    for (int y = 0; y < row; y++)
    {
        array[0, y] = s;
        s++;
    }
    for (int x = 1; x < col; x++)
    {
        array[x, row - 1] = s;
        s++;
    }
    for (int y = row - 2; y >= 0; y--)
    {
        array[col - 1, y] = s;
        s++;
    }
    for (int x = col - 2; x > 0; x--)
    {
        array[x, 0] = s;
        s++;
    }

    int c = 1;
    int d = 1;

    while (s < col * row)
    {

        while (array[c, d + 1] == 0)
        {
            array[c, d] = s;
            s++;
            d++;
        }


        while (array[c + 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c++;
        }


        while (array[c, d - 1] == 0)
        {
            array[c, d] = s;
            s++;
            d--;
        }


        while (array[c - 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c--;
        }
    }


    for (int x = 0; x < col; x++)
    {
        for (int y = 0; y < row; y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = s;
            }
        }
    }
}

void arrayOutput(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write("0" + arr[i, j] + "  ");
            }
            else
                Console.Write(arr[i, j] + "  ");
        }

        Console.WriteLine(" ");
    }
}