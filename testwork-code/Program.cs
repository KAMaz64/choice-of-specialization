/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначалальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

Console.Clear();

Console.WriteLine("Введите элементы нового массива через запятую и пробел");

string[] newArray = Console.ReadLine().Split(", ");
Console.WriteLine();

int y = 3;
int len = newArray.Length;
int x = NumberOfShort(newArray, len, y);

string[] newArrayShort = CreateArrayOfShortElements(newArray, len, x, y);

Console.WriteLine("Массив из элементов заданного массива, длина которых не превышает 3:");
PrintArray(newArrayShort);

int NumberOfShort (string [] inarray, int inarraylen, int shortsize)
{
    int shortElements = 0;
    for (int i = 0; i < inarraylen; i++)
    {
        if (inarray[i].Length <= shortsize)
        {
            shortElements++;
        }
    }
    return shortElements; 
}

string [] CreateArrayOfShortElements (string[] originalarray, int originalarraylen, int numberofshort, int sizeofshort)
{
    int j = 0;
    string[] shortArray = new string[numberofshort];

    for (int i = 0; i < originalarraylen; i++)
    {
        if (originalarray[i].Length <= sizeofshort)
        {
            shortArray[j] = originalarray[i];
            j++;
        }
    }
    return shortArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
