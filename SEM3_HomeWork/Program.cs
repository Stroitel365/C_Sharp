/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

/* Console.WriteLine("Введите пяизначное число");
int pol = int.Parse(Console.ReadLine());

if ((pol / 10000 == pol % 10) && ((pol / 1000 % 10 == pol % 100 / 10)))
{
    Console.Write("YES");
}
else
{
    Console.Write("NO");
} */

/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* Console.Write("Введите координату х первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату z первой точки: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату z второй точки: ");
int z2 = int.Parse(Console.ReadLine());

double rast = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Растояние между точками : {rast:f2}");
//Console.Write($"Растояние между точками : {Math.Round(rast, 2, MidpointRounding.ToNegativeInfinity)}"); */

/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/* Console.Write("Введите число (N): ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i,3)}, ");
} */