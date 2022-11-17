/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.WriteLine("Введите число число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число число N");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение функции {ackermannFunction(numberM, numberN)}");

int ackermannFunction(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return ackermannFunction(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return ackermannFunction(m - 1, ackermannFunction(m, n - 1));
    }
    return ackermannFunction(m, n);
}