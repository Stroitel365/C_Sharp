/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/* Console.Clear();
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите в какую степень возвести число А: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write($"Результат возведения в степень: {aPOWb(a,b)}");

int aPOWb(int a, int b)
{
    int pow = (int)Math.Pow(a,b);
    return pow;
} */

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

/* Console.Clear();
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма цифр в числе {a} = {SumCifr(a)}");

int SumCifr(int a)
{
    int sum =0;
    while (a%10!=0)
    {
        sum=sum+a%10;
        a=a/10;
    }
    return sum;
} */


/* Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.Clear();

int[] ar = FillArray();
//PrintArray(ar);
Console.WriteLine();
//PrintArrayChit(ar);
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", ar)} ]");


int[] FillArray()
{
    int[] array = new int[8]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(500);
    }
    return array;
}

void PrintArray(int[] arr)
{
    //Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    } 
    //Console.Write("]");

}

void PrintArrayChit(int[] massive)
{
    //Console.Write("[");
    Console.Write(Enumerable.Range(0, massive.Length).Aggregate("", (f, i) => f + $"{massive[i]}, ")); 
    //Console.Write("]");
}

