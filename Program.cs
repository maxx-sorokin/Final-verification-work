/* Задача. Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */

Console.WriteLine("Сколько строк будете вводить?");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

Console.WriteLine($"Введите строки");

string[] strings = EnteringArray(n);
PrintArray(strings);
Console.WriteLine();

int count = CountThreeSymbols(strings);

if (count > 0)
{
    string[] newStrings = ThreeSymbols(strings, count);
    PrintArray(newStrings);
}
else
{
    Console.WriteLine("Нужных строк нет");
}

int CountThreeSymbols(string[] array)
{
    int count = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] ThreeSymbols(string[] array, int count)
{
    string[] newArray = new string[count];

    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string[] EnteringArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}