// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintEvenNumbers(int m, int n)
{
    if (m > n)
        return;

    if (m % 2 == 0)
        Console.WriteLine(m);

    PrintEvenNumbers(m + 1, n);
}

int numberM = ReadInt($"Введите число М");
int numberN = ReadInt($"Введите число N");

if (numberM < numberN)
{
    Console.WriteLine($"Чётные числа в промежутке от {numberM} до {numberN}:");
    PrintEvenNumbers(numberM, numberN);
}
else
{
    Console.WriteLine($"Промежуток задан неверно: {numberM} > {numberN}:");
}