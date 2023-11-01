/* Задача:

Написать программу, которая из имебщегося массива строк формирует
массив из строк, длина которых меньше либо равна 3 символам.
Первоначально массив можно ввести с клавиатуры, либо задать
на старте выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами.

*/

Console.Clear();

string[] GetArrayStringConsole (string consoleText)
{
    string[] arrayText = new string[consoleText.Length];
    arrayText = consoleText.Split(",");
    return arrayText;
}
