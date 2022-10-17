/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

/* 
int[,] array = GetArray(5, 4, 0, 9);
PrintArray(array);
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    array = SortColumnByDecrisedValue(array,i);
}
PrintArray(array);
 */

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7 

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/* 
int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);
int row = rowWithMinSum(array);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {row} строка");

 */


/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
/* 
int[,] firstMatrix = GetArray(2, 2, 0, 9);
int[,] secondMatrix = GetArray(2, 2, 0, 9);
// int[,] firstMatrix = new int[,] {{2,4},{3,2}};
// int[,] secondMatrix = new int[,] {{3,4},{3,3}};

PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
int[,] martixMult = MatrixMultiplication(firstMatrix, secondMatrix);
Console.WriteLine();
PrintArray(martixMult);
 */

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

/* 
int[,,] array3D = Random3DArray(2, 2, 2, 10, 99);
Print3DArray(array3D);
 */



/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


const int cellWight = 3;
int[,] array62 = new int[4, 4];
PrintArray(array62);
Console.WriteLine();
array62 = MakeSpiralArray(array62, 1, 0, 0);
PrintArrayWithSetWight(array62);

// FUNCTIONS


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

void PrintArrayWithSetWight(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],cellWight} ");
        }
        Console.WriteLine();
    }
}

int FindColumnIndexForMaxElementInRowRange(int[,] array, int rowIndex, int startColumnIndex)
{
    int maxColumnIndex = startColumnIndex;
    int maxElement = array[rowIndex, startColumnIndex];
    for (int j = startColumnIndex; j < array.GetLength(1); j++)
    {
        if (maxElement < array[rowIndex, j])
        {
            maxElement = array[rowIndex, j];
            maxColumnIndex = j;
        }
    }
    return maxColumnIndex;
}

int[,] SortColumnByDecrisedValue(int[,] array, int rowIndex)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int minColumnIndex = FindColumnIndexForMaxElementInRowRange(array, rowIndex, j);
        int temp = array[rowIndex, j];
        array[rowIndex, j] = array[rowIndex, minColumnIndex];
        array[rowIndex, minColumnIndex] = temp;
    }
    return array;
}

int rowWithMinSum(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i, j];
        }
        sums[i] = tempSum;
    }
    int indexOfMaxSums = 0;
    int maxSumTemp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (sums[i] > maxSumTemp)
        {
            maxSumTemp = sums[i];
            indexOfMaxSums = i;
        }
    }
    return indexOfMaxSums;
}

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] martixMult = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < martixMult.GetLength(0); i++)
    {
        for (int j = 0; j < martixMult.GetLength(1); j++)
        {
            int tempSum = 0;
            for (int p = 0; p < firstMatrix.GetLength(1); p++)
            {
                tempSum += firstMatrix[i, p] * secondMatrix[p, j];
            }
            martixMult[i, j] = tempSum;
        }
    }
    return martixMult;
}

bool CheckDublicates(int[,,] array, int checkValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == checkValue)
                {
                    return true;
                }
            }

        }

    }
    return false;
}

int[,,] Random3DArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
                bool check = false;
                while (check != true)
                {
                    check = CheckDublicates(result, result[i, j, k]);
                    result[i, j, k] = new Random().Next(minValue, maxValue + 1);
                }
            }
        }
    }

    //result = CorrectDublicates(result);
    return result;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,] MakeSpiralArray(int[,] array, int count, int row, int column)
{
    if ((row == 0)||(column==array.GetLength(1)-1))
    {
        if ((0 <= column) && (column < array.GetLength(1)) && (0 <= row) && (row < array.GetLength(0)) && (array[row, column] == 0))
        {
            array[row, column] = count;
            count++;
            MakeSpiralArray(array, count, row, column + 1);
            MakeSpiralArray(array, count, row + 1, column);
            MakeSpiralArray(array, count, row, column - 1);
            MakeSpiralArray(array, count, row - 1, column);

        }
    }
    else if ((0 <= column) && (column < array.GetLength(1)) && (0 <= row) && (row < array.GetLength(0)) && (array[row, column] == 0))
    {
        array[row, column] = count;
        count++;
        MakeSpiralArray(array, count, row, column - 1);
        MakeSpiralArray(array, count, row - 1, column);
        MakeSpiralArray(array, count, row, column + 1);
        MakeSpiralArray(array, count, row + 1, column);

    }
    return array;
}



