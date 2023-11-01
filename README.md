## �������� ������.

### ������:
�������� ���������, ������� �� ���������� ������� ����� 
��������� ������ �� �����, ����� ������� ������ ����
����� 3 ��������. �������������� ������ ����� ������ � ����������, ���� ������ �� ������ ���������� ���������.
��� ������� �� ������������� ������������ �����������,
����� �������� ������������� ���������.

[����� �������� ����������� ������ �� ��������� �����](Final_Test.md)

����-�����:

![](block_diagram.drawio.png)


### ������� ������:

1. ���������� ������ �� ������� � ������ ����� ������� c ������� ������ `GetArrayStringConsole`:
```cs
string[] GetArrayStringConsole (string consoleText)
{
    string[] arrayText = new string[consoleText.Length];
    arrayText = consoleText.Split(",");
    return arrayText;
}
```

2. ���������� �������� �� ������� � ������� ������ `GetArrayThreeSimvol`:
```cs
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
```

3. ����� ���������� �� ������� � ������� � ������� ������ `PrintArray`:
```cs
void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
```

4. �������� ����������������� ���� ������ ��� ������ ������������� �������:
```cs
Console.Write("������� ����� �������� ����� �������: ");
string inStringSimvol = Console.ReadLine() ?? "";
string[] arraySimvol = GetArrayStringConsole(inStringSimvol);
Console.WriteLine();
Console.Write("��������� �������: ");
PrintArray(arraySimvol);
Console.WriteLine();
Console.Write("��������� �������, ����� ������� ������ ���� ����� 3: ");
PrintArray(GetArrayThreeSimvol(arraySimvol));
Console.WriteLine();
```