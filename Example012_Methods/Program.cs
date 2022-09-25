/* //ТИП 1. Ничего не принимают на ввод и ничего не возвращают обратно в прогу.  Напрмер, подписать авторство текста 

void Methdod1()
{
    Console.WriteLine(" Author ...");
}

Methdod1(); // -Вызов метода в теле кода
 */

/* //ТИП 2 Что-то принимают из программы и ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения"); /// - вывоз метода

// Иногда нужно объявить переменную для метода
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}

Method21(msg:"Текст сообщения",4); /// - вывоз метода описывает какой текст мы хотим увидеть и сколько раз (count)
//если именнованные переменные можно менять  их местами
Method21(count: 4, msg:"Текст сообщения 2.0"); */

/* // ТИП 3 Ничего не принимают из программы и что-то возвращают в программу

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.Write(year); */

/* // ТИП 4  Что-то принимает из программы и что-то возвращает в программу

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string Method41(int count, string text) //тоже что предыдущий метод, только через for
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
        {
            result = result + text;
        }
    return result;
}

string res = Method41(10, "ABCDe ");
Console.Write(res); */

// ЦИКЛ в ЦИКЛЕ

/* // Вывод таблицы умножения на экран

for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} х {j} = {i * j}");
    }
    Console.WriteLine();
}
 */

/* // Заменить в тексте все пробелы на _, к на К,  С на с

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
               + "ежели бы вас послали вместо нашего милого Винценгероде,"
               + "вы бы взяли приступом согласие прусского короля. "
               + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty" // - к строке можно обращатся как к массиву (через индексы от 0 до конца строки) s[2] = e.
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(text);
Console.WriteLine();
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine(); */

// метод поиска максимума

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);