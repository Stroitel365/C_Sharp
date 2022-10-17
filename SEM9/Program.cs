// Задать значение и вывести все натуральные числа до этого числа 

/* Console.Write(" Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Recursia(n, 1)); */

/// Натуральные числа от n до m
/* 
Console.Write(" Введите число: min ");
int min = int.Parse(Console.ReadLine()!);

Console.Write(" Введите число: max ");
int max = int.Parse(Console.ReadLine()!);

Console.WriteLine(Recursia(max, min));
 */
// Задача 67 Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
//453 -> 12
//45   -> 9

/* 
Console.Write(" Введите число:  ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в цисле равна : {SummaChisel(number)}");
 */

// Задача 69 Напишите программу, которая на вход принимет два числа А и В и возводит число А
// в целую степень В с помощью рекурсии

Console.Write(" Введите число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write(" Введите в какую степень возводить:  ");
int b = int.Parse(Console.ReadLine()!);
Console.Write($" Число {a} в степени {b} равно {APowerB(a,b)} ");

// FUNCTIONS


string Recursia(int n, int minValue)
{
    if (minValue == n)
    {
        return n.ToString();
    }
    return (minValue + " " + Recursia(n, minValue + 1));
}

int SummaChisel(int value)
{
    if (value == 0) return 0;
    return (value % 10 + SummaChisel(value / 10));
}

int APowerB(int number, int power)
{
    if(power==0) return 1;
    return (number*APowerB(number,power-1));
}


