Console.WriteLine("Введите число");

int A = int.Parse(Console.ReadLine());//int A = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= A; i++)
{
    sum = sum + i;
}
Console.WriteLine($"Сумма от 1 до {A}: {sum}");