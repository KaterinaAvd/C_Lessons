// Task_38
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];
for (int i = 0; i < array.Length; i++)  
array [i] = Math.Round(new Random().NextDouble() * (100 - 0) + 0, 2);
Console.WriteLine($"Случайный массив из {N} элементов: [{string.Join(" ", array)}]");
double max = array [0], min = array [0];
for (int i = 1; i < array.Length; i++)
    if (max < array [i])
        max = array [i];
    else
       if (min > array [i])
        min = array [i];
double diff = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {diff}");