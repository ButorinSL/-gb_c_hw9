// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int m, int n)
{
    if (m > n)

        return 0;

    return m + SumNumbers(m + 1, n);
}


int numberM = ReadInt($"Введите число М");
int numberN = ReadInt($"Введите число N");
// System.Console.WriteLine(SumNumbers(numberM, numberN));

if (numberM < numberN)
{
    Console.WriteLine($"Сумма чисел в промежутке от {numberM} до {numberN}: = {SumNumbers(numberM, numberN)}");

}
else
{
    Console.WriteLine($"Промежуток задан неверно: {numberM} > {numberN}:");
}