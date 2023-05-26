// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите левую границу массива: ");
int leftRange = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите правую границу массива");
int rightRange = Convert.ToInt32(Console.ReadLine());

Console.Write($"Массив из {size} элементов: ");
Console.WriteLine("[" + string.Join(", ", myArray(size, leftRange, rightRange)) + "]");

int[] myArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange);
    }
    return arr;

}
