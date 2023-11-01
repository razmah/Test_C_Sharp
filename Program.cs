/* Задача:

Написать программу, которая из имебщегося массива строк формирует
массив из строк, длина которых меньше либо равна 3 символам.
Первоначально массив можно ввести с клавиатуры, либо задать
на старте выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами.

*/

Console.Clear();


Console.Write("Введите набор символов через запятую: ");
string inStringSimvol = Console.ReadLine() ?? "";
string[] arraySimvol = GetArrayStringConsole(inStringSimvol);
Console.WriteLine();
Console.Write("Введенные символы: ");
PrintArray(arraySimvol);
Console.WriteLine();
Console.Write("Введенные символы, длина которых меньше либо равно 3: ");
PrintArray(GetArrayThreeSimvol(arraySimvol));
Console.WriteLine();


string[] GetArrayStringConsole (string consoleText)
{
    string[] arrayText = new string[consoleText.Length];
    arrayText = consoleText.Split(",");
    return arrayText;
}

string[] GetArrayThreeSimvol (string[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            temp++;
        }
    }
    string[] arrayThreeSimvol = new string[temp];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string simvol = array[i];
        if (simvol.Length <= 3)
        {
            arrayThreeSimvol[j] = simvol;
            j++;
        }
    }
    return arrayThreeSimvol;
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}