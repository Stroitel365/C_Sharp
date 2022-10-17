
/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
/* 
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumpersFromNto1(n, 1));
 */

/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

/*  
Console.Write("Введите минимальное число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное число:  ");
int b = int.Parse(Console.ReadLine()!);
Console.Write($" Сумма чисел от {a} до {b} равно {SumFromAtoB(a,b)}");


 */

/* 
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */
/* 
Console.Write("Введите первый аргумент: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второй аргумент: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write($" Функция Аккермна от аргументов от {a} и {b} равна {AkkFunction(a,b)}");

 */
//FUNCTIONS

string NumpersFromNto1(int n, int minValue)
{
    if (minValue == n)
    {
        return n.ToString();
    }
    return (NumpersFromNto1(n, minValue + 1) + " " + minValue);
}

int SumFromAtoB(int numberMIN, int numberMAX)
{
    if (numberMAX == numberMIN) return numberMIN;
    return (numberMAX + SumFromAtoB(numberMIN, numberMAX - 1));
}


int AkkFunction(int firstArgumentM, int secondArgumentN)
{
    if (firstArgumentM == 0) return secondArgumentN + 1;
    if (secondArgumentN == 0 && firstArgumentM>0 ) return AkkFunction(firstArgumentM - 1, 1);
    return AkkFunction(firstArgumentM - 1, AkkFunction(firstArgumentM, secondArgumentN - 1));
}
