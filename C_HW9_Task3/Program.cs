// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
    

    int Akerman(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Akerman(m - 1, 1);
        else
            return Akerman(m - 1, Akerman(m, n - 1));
    }

int numberM = ReadInt($"Введите число М");
int numberN = ReadInt($"Введите число N");

Console.WriteLine($"Результат функции Аккермана для чисел {numberM} и {numberN}: {Akerman(numberM, numberN)}");