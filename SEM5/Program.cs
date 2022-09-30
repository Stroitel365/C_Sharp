/* **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

//Console.Clear();

/* int[] mas = GetArray(10, -10, 11);
Console.WriteLine($"[{String.Join(", ", mas)}]");
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = mas[i] * (-1);
}
Console.Write($"[{String.Join(", ", mas)}]"); 
*/

/* **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

/* int[] arr = GetArray(10, -10, 11);
Console.WriteLine($"[{String.Join(", ", arr)}]");
Console.Write(" Введите искомое число: ");
int find = int.Parse(Console.ReadLine()!);
//bool answer = Contains(arr,find);
if (Contains(arr, find))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
 */
/* **Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

/* int[] arr = GetArray(123, -100, 199);
//int[] arr = GetArray(123, 10, 99);// Для проверки
Console.WriteLine($"[{String.Join(", ", arr)}]");
int howMany = HowManyInTheRange(arr,10,99);
Console.Write($"В массиве количество элементов в промежутке [10,99] = {howMany}"); */


/* **Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

/* int[] arra = GetArray(10, -10, 9);
int[] res = FactorPair(arra);
Console.WriteLine($"[{String.Join(", ", arra)}]");
Console.WriteLine($"[{String.Join(", ", res)}]"); */



/* // Functions
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

bool Contains(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            return true;
        }
    }
    return false;
}

int HowManyInTheRange(int[] array, int IntMin, int IntMax)
{
    int a = 0; // Счетчик
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= IntMin && array[i] <= IntMax)
        {
            a++;
        }
    }
    return a;
}

int[] FactorPair(int[] array)
{
    int newSize = 0;
    if (array.Length % 2 == 0)
    {
        newSize = array.Length / 2;
    }
    else
    {
        newSize = array.Length / 2 + 1;
    } 

    //int newSize = (int)Math.DivRem(array.Length, 2, out int rem) + rem;
    int[] newArr = new int[newSize];
    for (int i = 0, j = array.Length-1; i < newSize; i++, j--)
    {
        if (i !=j){
            newArr[i]=array[i]*array[j];
        }
        else{
            newArr[i]=array[i];
        }

    }
    return newArr;
}
 */