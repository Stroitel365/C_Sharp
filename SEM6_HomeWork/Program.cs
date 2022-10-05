/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/
/* 
int[] array41 = GetArray(15, -100, 100);
Console.WriteLine($"[{String.Join(", ", array41)}]");
int c = HowManyAboveZero(array41);
Console.WriteLine($"Количество цифр больше 0 = {c}");
*/


/* 
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/
/* 
Console.WriteLine("Введите коэффициент k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент b2: ");
double b2 = double.Parse(Console.ReadLine()!);

double x =(b1-b2)/(k2-k1);
double y = k1*x+b1;

Console.WriteLine($"Координаты точки пересечения ({x:f1};{y:f1})");


 */

// Functions

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int HowManyAboveZero(int[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) k = k + 1;

    }
    return k;
}