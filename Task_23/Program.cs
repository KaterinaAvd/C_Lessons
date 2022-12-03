// Task_23
Console.Clear();
Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write($"{Math.Pow(i,3)} ");