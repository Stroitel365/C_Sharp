/* Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

/* Console.Write("Введите первое целое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = int.Parse(Console.ReadLine());

if (a > b) 
{
    Console.WriteLine($"max = {a}");
}
else 
{
    Console.WriteLine($" max = {b}");
} */

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/* Console.Write("Введите первое целое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int c = int.Parse(Console.ReadLine());

if (a>b)
{
    if (a>c)
    {
        Console.WriteLine($"max = {a}");
    }
    else
    {
        Console.WriteLine($"max = {c}");
    }
}
else 
{
    if (b>c)
    {
        Console.WriteLine($"max = {b}");
    }
    else
    {
        Console.WriteLine($"max = {c}");
    }
} */

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

/* Console.Write("Введите целое число для проверки на четность: ");
int a = int.Parse(Console.ReadLine());

if (a%2==0)
{
    Console.WriteLine("Да, четное.");
}
else
{
    Console.WriteLine("Неа, не четное.");
} */

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

/* Console.Write("Введите целое положительное число: ");
int a = int.Parse(Console.ReadLine());
int b = 0;

while ( b <= a )
{
    Console.WriteLine($"{b}, ");
    b=b+2;
} */