// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Введите первое число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число m: ");
int m = Convert.ToInt32(Console.ReadLine());

int FindAckermanFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return FindAckermanFunction(n - 1, 1);
    }
    else
    {
        return FindAckermanFunction(n - 1, FindAckermanFunction(n, m - 1));
    }
}

int result = FindAckermanFunction(n, m);
Console.WriteLine($"Результат функции Аккермана: {result}");