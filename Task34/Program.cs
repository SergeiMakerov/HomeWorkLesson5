/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);


int CountOfEvenNum(int[] mass)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
        if (mass[i] % 2 == 0)
        {
            count++;
        }
    return count;
}

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.WriteLine("Наш массив: ");
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Всего {numbers.Length} числа, {CountOfEvenNum(numbers)} из них чётные");
}