// Задайте двумерный массив размером мхн заполненный случайными целыми числами

/* Console.WriteLine("Количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows,columns, 0, 10);
PrintArray(array);
 */

//Задайте двумерный массив размера mxn каждый элемент в массиве находится по формуле А= m+n + вывести массив
/* 
Console.WriteLine("Количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArraySumIndex(rows,columns);
PrintArray(array);

 */

// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные и замените эти элементы на их квардраты
/* 
int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
Console.WriteLine();
array = EvenIndexPower2(array);
PrintArray(array);

 */

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] array = GetArray(4, 4, 0, 10);
PrintArray(array);
Console.WriteLine();
int sumMainDiagonal = MainDiagonalElemetsSum(array);
Console.WriteLine($"Сумма элементов главной диагонали: {sumMainDiagonal}");


// Function
int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[,] GetArraySumIndex(int row, int col)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] EvenIndexPower2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0)) array[i, j] = (int)Math.Pow(array[i, j], 2);
        }

    }
    return array;
}

int MainDiagonalElemetsSum(int[,] array)
{
    int sumMainDiagonal = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sumMainDiagonal += array[i, j];
        }

    }
    return sumMainDiagonal;
}

