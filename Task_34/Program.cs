// Task_34
Console.Clear();
Console.Write("Введите количество элементов массива (до 900): ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < array.Length; i++)   
array[i] = new Random().Next(100, 1000); // [100, 999]
Console.WriteLine($"Случайный массив из {N} трехзначных положительных элементов: [{string.Join(", ", array)}]");
int j = 0;
for (int k = 0; k < array.Length; k++)
{
    if (array[k] % 2 == 0)
        j = j + 1;
}
Console.WriteLine($"В массиве {j} четных элементов.");