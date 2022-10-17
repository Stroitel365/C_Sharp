/* **Задача 53:** Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2 */

/* int[,] array53 = GetArray(4, 6, 0, 9);
PrintArray(array53);
Console.WriteLine();
for (int j = 0; j < array53.GetLength(1); j++)
{
    int temp = array53[0, j];
    array53[0, j] = array53[array53.GetLength(0)-1, j];
    array53[array53.GetLength(0)-1, j] = temp;
}
PrintArray(array53); */


/* **Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
 */

/* 
int[,] array55 = GetArray(4, 4, 0, 9);
PrintArray(array55);
Console.WriteLine();
if (array55.GetLength(0) != array55.GetLength(1))
{
    Console.WriteLine("Невозможно заменить столбцы на строки");
}
else
{
    int[,] arrayRevers = ReversArray(array55);
    Console.WriteLine();
    PrintArray(arrayRevers);
}
 */

/* Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
*/
/* 
int[,] array59 = GetArray(4, 4, 0, 9);
PrintArray(array59);
Console.WriteLine();

int minRowIndex = 0;
int minColumnsIndex = 0;
int minElement = array59[0, 0];
for (int i = 0; i < array59.GetLength(0); i++)
{
    for (int j = 0; j < array59.GetLength(1); j++)
    {
        if (minElement > array59[i, j])
        {
            minElement = array59[i, j];
            minRowIndex = i;
            minColumnsIndex = j;
        }
    }
}
Console.WriteLine($"{minElement} {minRowIndex} {minColumnsIndex}");
Console.WriteLine();

int[,] array59new = DeleteRowAndColumnWithMinElement(array59, minRowIndex, minColumnsIndex);
PrintArray(array59new);
*/

/* 
Отсортировать нечетные столбцы массива по возрастанию. 
Вывести массив изначальный и массив с отсортированными нечетными столбцами
*/
/* 
int[,] array = GetArray(15, 4, 0, 9);
PrintArray(array);
Console.WriteLine();
for (int j = 1; j < array.GetLength(1); j=j+2)
{
    array = SortColumnByIncrisedValue(array,j);
}
PrintArray(array);
// int minRowNumber = FindRowIndexForMinElementInColumnRange(array, 0, 0);
// Console.WriteLine(minRowNumber);
 */
/* 
// Functions

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

int[,] ReversArray(int[,] array)
{
    int[,] tempArray = new int[array.GetLength(0), array.GetLength(1)];
    //int[,] tempArray = array;
    //PrintArray(tempArray);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempArray[j, i] = array[i, j];
        }

    }
    return tempArray;
}

int[,] DeleteRowColumnWithMinElement(int[,] array, int minRowIndex, int minColumnsIndex)
{
    int[,] arrayNew = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0, newI = 0; i < array.GetLength(0); i++)
    {
        if (i == minRowIndex)
        {
            continue;
        }
        for (int j = 0, newJ = 0; j < array.GetLength(1); j++)
        {
            if (j == minColumnsIndex)
            {
                continue;
            }
            else
            {
                arrayNew[newI, newJ] = array[i, j];
                newJ++;
            }
        }
        newI++;
    }
    return arrayNew;
}

int FindRowIndexForMinElementInColumnRange(int[,] array, int columnIndex, int startRowIndex)
{
    int minRowIndex = startRowIndex;
    int minElement = array[startRowIndex, columnIndex];
    for (int i = startRowIndex; i < array.GetLength(0); i++)
    {
        if (minElement > array[i, columnIndex])
        {
            minElement = array[i, columnIndex];
            minRowIndex = i;
        }
    }
    return minRowIndex;
}

int[,] SortColumnByIncrisedValue(int[,] array, int columnIndex)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int minRowIndex = FindRowIndexForMinElementInColumnRange(array, columnIndex, i);
        int temp = array[i, columnIndex];
        array[i, columnIndex] = array[minRowIndex, columnIndex];
        array[minRowIndex, columnIndex] = temp;
    }
    return array;
}
 */
