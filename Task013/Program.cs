Console.WriteLine("Введите целое число: ");
int a = int.Parse(Console.ReadLine());
a = Math.Abs(a);
if (a >= 100)
{
    if (a > 999)
    {
        int i = 10;
        while (a / i > 1000)
        {
            i = i * 10;
        }
        Console.WriteLine("Третья цыфра числа: " + (a / i) % 10);
    }
    else
    {
        Console.WriteLine("Третья цифра числа: " + a % 10);
    }
}
else
{
    Console.WriteLine("Нет третьей цифры");
}