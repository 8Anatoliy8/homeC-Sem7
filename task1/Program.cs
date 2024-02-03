// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

void ShowNumbers (int start, int end)
{
    if (start == end)
    {
        Console.Write(end);
        return;
    }
    Console.Write(start + ", ");
    ShowNumbers(start + 1, end);
}

ShowNumbers(M,N);