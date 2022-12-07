// Task_Bonus_3
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < array.Length; i++)   
array[i] = new Random().Next(-100, 101); 
Console.WriteLine($"Случайный массив из {N} элементов: [{string.Join(", ", array)}]");
Console.Write($"Введите целое число K для сдвига массива (-{N} <= K <= {N}): ");
int K = Convert.ToInt32(Console.ReadLine());
if (K < 0)
{
    Array.Reverse(array, 0, -K);
    Array.Reverse(array, -K, array.Length + K);
    Array.Reverse(array, 0, array.Length);
    Console.WriteLine($"Массив со сдвигом на {-K} элементов влево: [{string.Join(", ", array)}]");
}
else
{
    Array.Reverse(array, 0, array.Length - K);
    Array.Reverse(array, array.Length - K, K);
    Array.Reverse(array, 0, array.Length);
    Console.WriteLine($"Массив со сдвигом на {K} элементов вправо: [{string.Join(", ", array)}]");
}