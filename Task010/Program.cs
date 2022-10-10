int Number = 0;
Console.WriteLine("Введите трёхзначное число: ");
Number = Convert.ToInt32(Console.ReadLine());
if (Number >= 100 && Number <= 999)
{
    int DecreaseByTen = Number / 10;
    int LastDigit = DecreaseByTen % 10;
    Console.WriteLine("Вторая цифра числа =" + LastDigit);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}