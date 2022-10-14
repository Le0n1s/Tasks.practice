//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

Console.WriteLine("Введите число");

int N = int.Parse(Console.ReadLine());//int A = Convert.ToInt32(Console.ReadLine());

int count = 0;

if (N == 0)
{
    count = 1;
}
else
{
    while (N != 0)
    {
        N /= 10;
        count += 1;
    }
}

Console.WriteLine(count);
