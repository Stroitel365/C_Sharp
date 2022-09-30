Console.Clear();

/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

/* int[] massive = GetArray(10, 100, 999);
int Chet = HowManyEvenNumbers(massive);
Console.WriteLine($"[{String.Join(", ", massive)}]");
Console.Write($"Количество четных числе в массиве: {Chet}"); */


/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/* int[] massiveZ36 = GetArray(10, 0, 10);
int sumUneven = GetSumOfUneven(massiveZ36);
Console.WriteLine($"[{String.Join(", ", massiveZ36)}]");
Console.Write($"Сумма элементов с нечетными индексами: {sumUneven}");
*/


/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76                                */
/* 
double[] massiveZ38 = GetDoubleArray(10, 1.5, 2.1);
Console.WriteLine($"[{String.Join(", ", massiveZ38)}]");
double massiveZ38_MIN = FindDoubleMIN(massiveZ38);
double massiveZ38_MAX = FindDoubleMAX(massiveZ38);
Console.WriteLine($"Сумма максимального элемента {massiveZ38_MAX:f3} и минимального элемента {massiveZ38_MIN:f3} = {(massiveZ38_MAX + massiveZ38_MIN):f3}");
 */



// Functions
/* 
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
 */
/*
int HowManyEvenNumbers(int[] array)
{
    int c = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            c++;
        }

    }
    return c;
}
 */
/* 
int GetSumOfUneven(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        i++;
        sum = sum + array[i];
    }
    return sum;
}
*/
/* 
double[] GetDoubleArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        double x = new Random().NextDouble();
        res[i] = Math.Round(x * (maxValue-minValue) + minValue, 3);
    }
    return res;
}

double FindDoubleMAX(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) { max = array[i]; }
    }
    return max;
}

double FindDoubleMIN(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) { min = array[i]; }
    }
    return min;
}
 */