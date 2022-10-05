// напишите программу которая разворачивает одномерный массив
/* 
int[] array = GetArray(8, 0, 20);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] reversArray = ReversArray2(array);
ReversArray1(array);

Console.WriteLine("Переворот по первому методу : ");
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine("Переворот по второму методу : ");
Console.WriteLine($"[{String.Join(", ", reversArray)}]");
*/


//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/* 
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первое число: ");
int c = int.Parse(Console.ReadLine()!);

if ((a < b + c) & (b < a + c) & (c < a + b))
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}
*/


/* **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

/* Console.WriteLine("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine()!);
int d10 = 1;
int result = 0;
while (number != 0)
{
    result = result + number % 2 * d10;
    number = number / 2;
    d10 = d10 * 10;

}
Console.WriteLine($"Двоичное представление числа: {result}");
 */


/* **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 
*/

/* 
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int first = 0;
int second = 1;
Console.Write($"{first} {second} ");
for (int i = 3; i <= n; i++)
{
    int temp = second + first;
    Console.Write($"{temp} ");
    first = second;
    second = temp;
}
*/

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

/* 
int[] array = GetArray(5, 0, 5);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"[{String.Join(", ", CopyArr(array))}]");
*/

// Function
/* 
int[] CopyArr(int[] arr)
{
    int[] arr2 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr2[i] = arr[i];
    }
    return arr2;
}
 */

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


void ReversArray1(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int k = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = k;
    }
}

void ReversArray3(string[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        string k = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = k;
    }
}

int[] ReversArray2(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - i - 1];
    }
    return result;
} */