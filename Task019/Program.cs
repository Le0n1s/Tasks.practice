int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int N = Prompt("Введите пятизначное число > ");
void Palindrome(int N)
{
    if (N > 10000 && N < 100000)
    {
        int number1 = N / 10000;
        int number5 = N % 10;
        if (number1 == number5)
        {
            int number2 = N / 1000 % 10;
            int number4 = N / 10 % 10;
            if (number2 == number4)
            {
                System.Console.WriteLine("Это число ЯВЛЯЕТСЯ полиндромом");
            }
            else
                System.Console.WriteLine("Это число НЕ является полиндромом");
        }
        else
            System.Console.WriteLine("Это число НЕ является полиндромом");
    }
    else
    {
        System.Console.WriteLine("Это не пятизначное число");

    }
}

Palindrome(N);