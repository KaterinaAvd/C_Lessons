// Task_36
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < array.Length; i++)   
array[i] = new Random().Next(1, 1000); // [1, 999]
Console.WriteLine($"Случайный массив из {N} элементов: [{string.Join(", ", array)}]");
int amount = 0;
for (int k = 0; k < array.Length;)
{
        amount = amount + array[k];
        k = k + 2;
}
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных местах: {amount}");