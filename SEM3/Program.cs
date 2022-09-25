//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/* Console.Write("Введите координату х: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координату y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.Write("Точка находится в 1 четверти");
}
else if (x < 0 && y > 0)
    {
        Console.Write("Точка находится в 2 четверти");
    }
else if  (x < 0 && y < 0)
    {
        Console.Write("Точка находится в 3 четверти");
    }
else if (x > 0 && y < 0)
    {
        Console.Write("Точка находится в 4 четверти");
    }
else 
    {
        Console.Write("Точка находится в центре координат");
    }
 */

/*  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

/* Console.Write("Введите координату х первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату х второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
int y2 = int.Parse(Console.ReadLine());

double rast = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Растояние между точками : {rast:f2}");
Console.Write($"Растояние между точками : {Math.Round(rast,2,MidpointRounding.ToNegativeInfinity)}"); */

/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.

2 -> 1,4 */

/* Console.Write("Введите число (N): ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i,2)} ");
} */