// Task 10
Console.Clear();
Console.Write("Введите целое трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = (n / 10) % 10;
Console.WriteLine($"Вторая цифра числа: {m}");