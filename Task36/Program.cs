/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int GetSummOddElements(int[] mass)
{
    int sum = 0;
    for (int i = 0; i < mass.Length; i += 2)
        sum = sum + mass[i];
    return sum;
}
void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
    }
}
void PrintArray(int[] numbers)
{
    Console.WriteLine("Наш массив: ");
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {GetSummOddElements(numbers)}");
}