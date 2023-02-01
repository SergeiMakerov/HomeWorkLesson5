/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int GetDifference(int[] mass)
{
    int max = Int32.MinValue;
    int min = Int32.MaxValue;

    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > max)
        {
            max = numbers[i];
        }
        if (mass[i] < min)
        {
            min = numbers[i];
        }
    }
    return max - min;
}

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine("Наш массив: ");
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным значением = {GetDifference(numbers)}");
}