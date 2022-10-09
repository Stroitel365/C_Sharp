/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 7 -2 -85
1 -3 8 -9
8 7 -7 9 */

/* 
Console.WriteLine("Количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows,columns, -100, 100);
PrintArray(array);
*/


/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2 */

/* 
int rows = new Random().Next(0, 11);
int columns = new Random().Next(0, 11);
Console.WriteLine($"{rows},{columns}");
int[,] array = GetArray(rows, columns, -100, 100);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите номер строки: ");
int rowNeeded = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер столбца: ");
int columnNeeded = int.Parse(Console.ReadLine()!);

if (rowNeeded <= array.GetLength(0) && (columnNeeded <= array.GetLength(1)))
{
    Console.WriteLine(array[rowNeeded, columnNeeded]);
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}
 */

/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/* 
int rows = new Random().Next(0, 10);
int columns = new Random().Next(0, 10);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
double[] middleValueArray = MiddleValueEachColumn(array);
Console.WriteLine($"[{String.Join(", ", middleValueArray)}]");
*/

//Funstions

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


double[] MiddleValueEachColumn(int[,] array)
{
    double[] middleValueArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sumTemp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumTemp += array[i, j];
        }
        middleValueArray[j] = (double) sumTemp / array.GetLength(0);
    }
    return middleValueArray;
}