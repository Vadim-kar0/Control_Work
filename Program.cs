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

