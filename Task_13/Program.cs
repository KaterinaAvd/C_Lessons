// Task 13
Console.Clear();
Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0;
if (Math.Abs(n) < 100)
    Console.WriteLine("Третья цифра числа отсутствует");
else
{
    while (Math.Abs(n) >= 100)
    {
        m = n % 10;
        n = n / 10;
    }
    Console.WriteLine($"Третья цифра числа: {Math.Abs(m)}");
}