Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string[length];
void FillArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    array[i] = Console.ReadLine();
}
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
FillArray(array);
PrintArray(array);
string[] GetResultArray(string[] array)
{
    int lengthNewArray = 0;
    string memory = " ";
    for (int i = 0; i < array.Length; i++)
    {
        memory = array[i];
        if (memory.Length<=3)
        {
            lengthNewArray++;
        }
    }
    string[] result = new string[lengthNewArray];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        memory = array[i];
        if (memory.Length<=3)
        {
             result[j]= memory;
             j++;
        }
    }
    return result;
}
Console.WriteLine();
string[] newArray = GetResultArray(array);
PrintArray(newArray);
