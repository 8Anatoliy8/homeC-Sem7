// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int [] CreateRandomArray (int size)
{
    int [] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next (-101, 101);
    }
    return array;
}

void ShowReverseArray (int [] arr, int size)
{
    if (size == 0)
    {
        return;
    }
    Console.Write($"Перевернутый Массив:[{string.Join ("; ", arr[size-1])}]");
    ShowReverseArray(arr, size-1);
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = CreateRandomArray (N);
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
ShowReverseArray(array, N);