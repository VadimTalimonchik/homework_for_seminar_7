// Задача 50.
// Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)

Console.Write("Введите номер строки: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int [,] numbers = new int [3, 4];
FillArray(numbers);

if (m > numbers.GetLength(0) || n > numbers.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет!");
}
else
{
    Console.WriteLine($"Значение элемента {m} строки и {n} столбца равно: {numbers[m-1, n-1]}");
}
Console.WriteLine();

PrintArray(numbers);
Console.WriteLine();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }   
        Console.WriteLine(""); 
    }
}
