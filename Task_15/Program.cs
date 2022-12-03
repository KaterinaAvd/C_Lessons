// Task 15
Console.Clear();
Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 6 || n == 7)
    Console.WriteLine("Да, это выходной!");
else
{
    if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5)
        Console.WriteLine("Нет, это НЕ выходной!");
    else 
        Console.WriteLine("Введенное число не соответствует ни одному дню недели");
}