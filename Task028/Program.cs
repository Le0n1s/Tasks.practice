/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/
int num = int.Parse(Console.ReadLine());

int result = multiplication(num);

Console.WriteLine(result);


int x = multiplication(num + 1);

Console.WriteLine(x);

int multiplication(int number)
{
    int count = 1;

    for (int i = 1; i <= number; i++)
    {
        count = count * i; // count *= i;
    }

    return count;
}

