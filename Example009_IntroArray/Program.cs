int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// Индексы      0  1  2  3  4  5  6  7  8
int[] array = {11,12,13,21,22,23,31,32,33};

int a1 = 11, a2 = 12, a3 = 1543,
    b1 = 21, b2 = 22, b3 = 39,
    c1 = 31, c2 = 32, c3 = 313;

int max = Max(Max(a1, b1, c1),
                Max(a2, b2, c2),
                Max(a3, b3, c3));

Console.WriteLine(max);