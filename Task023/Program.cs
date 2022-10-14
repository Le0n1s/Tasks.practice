/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int N = Prompt("Введите N > ");
int num = 1;
void CubeN(int num)
{
    while (num <= N)
    {
        int result = 0;
        result = num * num * num;
        System.Console.WriteLine(result);
        num++;
    }
}
CubeN(num);