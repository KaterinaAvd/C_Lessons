// Task_27
Console.Clear();
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int i = a % 10;
int j = a;
while (a != 0)
{
    sum = sum + i;
    a = a / 10;
    i = a % 10;
}
Console.WriteLine($"Сумма цифр в числе {j} равна {sum}");