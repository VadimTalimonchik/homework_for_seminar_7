// Задача 52.
// Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int rows, int columns)
{
    Random rnd = new Random();
    int[,] array = new int[rows, columns];
    int i = 0, j = 0;
    while (i < rows)
    {
        j = 0;
        while (j < columns)
        {
            array[i, j] = new Random().Next(0, 11);
            j++;
        }
        i++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    int i = 0, j = 0;
    while (i < array.GetLength(0))
    {
        j = 0;
        while (j < array.GetLength(1))
        {
            Console.Write("{0}\t", array[i, j]);
            j++;
        }
        Console.WriteLine(" ");
        i++;
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = new int[rows, columns];
array = CreateArray(rows, columns);
Console.WriteLine();
PrintArray(array);

void AverageInColumn(int[,] array)
{
    int i = 0, j = 0;
    double average = 0.0;
    while (j < columns)
    {
        i = 0;
        double sum = 0;
        while (i < rows)
        {
            sum += array[i, j];
            i++;
        }
        average = Math.Round((sum / i), 2);
        Console.WriteLine($"Среднее значение элементов {j} столбца {average}");
        j++;
    }
}
AverageInColumn(array);
