// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите номер строки массива: ");
int linePosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца массива: ");
int columnPosition = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [3,4];
RandomArray(numbers);

Console.WriteLine("Ваш массив: ");
PrintArray(numbers);

if (linePosition > numbers.GetLength(0) || columnPosition > numbers.GetLength(1))
{
    Console.WriteLine($"Числа в {linePosition} строке, в {columnPosition}-м столбце не существует.");
}
else if (linePosition == 1)
{
    Console.WriteLine($"Значение числа в {linePosition}-й строке в {columnPosition}-м столбце равно {numbers[linePosition-1,columnPosition-1]}");
}
else
{
    Console.WriteLine($"Значение числа во {linePosition}-й строке в {columnPosition}-м столбце равно {numbers[linePosition-1,columnPosition-1]}");
}

void RandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }   
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}