/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] array = new Int32[2, 2, 2];

array[0, 0, 0] = 66;
array[0, 1, 0] = 25;
array[1, 0, 0] = 34;
array[1, 1, 0] = 41;
array[0, 0, 1] = 27;
array[0, 1, 1] = 90;
array[1, 0, 1] = 26;
array[1, 1, 1] = 55;

/*
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

filling(array);
arrayOutput(array);

void filling(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                int num = new Random().Next(10, 100);
                if (num != arr[i, j, k])
                {
                    arr[i, j, k] = num;
                }
            }
        }
    }
}

void arrayOutput(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write(arr[i, j, k] + "  (" + i + j + k + ") ");
            }
        }

        Console.WriteLine(" ");
    }
}