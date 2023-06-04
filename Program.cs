Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new string[length];
for (int i = 0; i < length; i++)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    array[i] = Console.ReadLine();
}