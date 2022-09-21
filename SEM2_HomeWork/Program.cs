/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */
/* Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());
Console.Write($"Вторая цифра : {a/10-a/100*10}"); */

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
//ВАРИАНТ 1
/* int SkolkoCifr(int arg1) // Определяем сколько цифр в числе
{
    int delitel = 10;
    int i=1; // счетчик разрядов
    while (arg1 / delitel != 0)
    {
        delitel = delitel * 10;
        i++;
    }
    return i;
}

Console.WriteLine("Введите целое число");
int arg1 = int.Parse(Console.ReadLine());       
if (arg1/100!=0)
{
    int i = SkolkoCifr(arg1);
//    Console.WriteLine(i);
    int a = (int)((arg1/(Math.Pow(10,i-3)))%10);// отсекаем первые 3 цифры делением и берем остаток
    Console.WriteLine($"Третья цифра : {a}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
 */
//ВАРИАНТ 2
/* Console.WriteLine("Введите число");
string arg1 = Console.ReadLine();
int a= Convert.ToInt32(arg1);
Console.WriteLine($"Третья цифра : {(int)((a/(Math.Pow(10,arg1.Length-3)))%10)}"); */

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

/* Console.WriteLine("Введите число");
int arg2 = int.Parse(Console.ReadLine());
if   (arg2<1|arg2>7)
{
    Console.WriteLine("Число не является номером дня в неделе");
}
else if (arg2<6)
{
    Console.Write("NO");
}
else {Console.Write("YES");} */