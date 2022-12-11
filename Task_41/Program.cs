// Task_41
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Вы ввели {M} чисел: {string.Join(", ", array)}");
int n = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
        n = n + 1;
Console.WriteLine($"Среди них {n} чисел больше нуля");