Console.Clear();
Console.WriteLine("Программа для вывода из массива значений, размер которых меньше или равен трем символам");
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "");
string[] array = new string[size];
FillArray(array);
string[] secondArray = FormNewArray(array);
PrintArray(secondArray);

void FillArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        stringArray[i] = Console.ReadLine();
    }
}

string[] FormNewArray(string[] stringArray)
{
    int s = 0;
    for (int j = 0; j < stringArray.Length; j++)
    {
        if (stringArray[j].Length <= 3)
            s++;
    }
    string[] newArray = new string[s];
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            newArray[count] = stringArray[i];
            count++;
        }
    }
    return newArray;
}
void PrintArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"{stringArray[i]}, ");
    }
}