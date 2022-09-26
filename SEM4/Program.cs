// Написать программу принимающуюся на вход А и выдает сумму чисел от 1 до А
/* int GetSum(int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine($" Сумма чисел от 1 до {A} равна {GetSum(A)}"); */

/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */
/* 
Console.Clear();
Console.Write("Введите число А: ");
string A = Console.ReadLine()!;
Console.WriteLine($"Количество цифр в числе {GetLength(A)}");
Console.WriteLine($"Количество цифр в числе вторым методом {GetLength2(int.Parse(A))}");


int GetLength(string number)
{
    return number.Length;
}

// Variant 2

int GetLength2(int number)
{
    return (int)Math.Log10(number)+1; // 
} */

/* Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4  -> 24
5  -> 120 */
/* Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($" Произведение чисел от 1 до {A} =  {GetFact(A)}");
Console.WriteLine($" Произведение чисел от 1 до {A} методом 2 =  {Factorial(A)}");

int GetFact(int limit)
{
    int fact = 1;
    for (int i = 2; i <= limit; i++)
    {
        fact = fact * i;
    }
    return fact;
}

int Factorial(int n)
{
    return Enumerable.Range(1, n).Aggregate(1, (f, i) => f * i); 
// Enumerable -некоторое перечисляемое, например строка ( перечисляет символы), Range - функция наподобии цикла for c int start до int count с шагом 1 (и только 1)
// Aggregate - метод (аналог тела цикла в строке)
} */

/* Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */
/* Console.Clear();

int[] ar = FillArray();
PrintArray(ar);
Console.WriteLine();
PrintArrayChit(ar);
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", ar)}]");


int[] FillArray()
{
    int[] array = new int[8]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(0,2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    } 

}

void PrintArrayChit(int[] massive)
{
    Console.Write(Enumerable.Range(0, massive.Length).Aggregate("", (f, i) => f + $" {massive[i]} ")); 
}
 */

