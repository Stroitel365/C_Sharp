// Напишите программу расчета квадрата цисла
//Console.WriteLine("Введите число: ");
//int number =int.Parse(Console.ReadLine());
// Возведение в квадрат мат методом
//int sqr = number*number;
//Console.WriteLine($"Квадрат числа {number} равен = {sqr}");
//  Метод с использованием библиотеки
//int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
//Console.WriteLine($"Вложенная библиотека! Квадрат числа {number} равен = {sqr1}"); 




/* Console.WriteLine("Программа для определения является ли одно число квадратом другого ");
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a==Convert.ToInt32(Math.Pow(b,2)))
{
    Console.WriteLine($"{a} - квадрат {b}");
}
else 
{
    Console.WriteLine($"{a} - не квадрат {b}");
} */

//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

/* Console.WriteLine("Программа для определения дня недели по заданному номеру ");
Console.WriteLine("Введите номер дня: ");
int day_number = int.Parse(Console.ReadLine());
switch(day_number)
{
    case 1: Console.WriteLine("Понедельник");
    break;
    case 2: Console.WriteLine("Вторник");
    break;
    case 3: Console.WriteLine("Среда");
    break;
    case 4: Console.WriteLine("Четверг");
    break;
    case 5: Console.WriteLine("Пятница");
    break;
    case 6: Console.WriteLine("Суббота");
    break;
    case 7: Console.WriteLine("Воскресенье");
    break;
    default: Console.WriteLine("Число не является номером дня недели");
    break;
} */



// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите целое число: ");

/* int n = int.Parse(Console.ReadLine());
int a = -n;
while (a <= n)
{
    Console.Write($"{a}, ");
    a++;
} */


//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа. 
// 456 -> 6
// 782 -> 2
// 918 -> 8

/* Console.WriteLine("Введите трехзначное число")
int n = int.Parse(Console.ReadLine());
Console.WriteLine("последняя цифра числа "+n+"-"+n%10);
Console.WriteLine($"последняя цифра числа {n}-{n%10}"); */