// Task_Bonus
Console.Clear();
Console.WriteLine("Введите несколько целых чисел от 0 до 100: ");
int n = Convert.ToInt32(Console.ReadLine());
int max = 0; // максимальный элемент последовательности
int max1 = 0; // второй по величине элемент последовательности
while(n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max )
    {
        max1 = max;
        max = n;
    }
    else
    {
        if(n > max1)
            max1 = n;
    }
}
Console.WriteLine($"Второй по величине элемент последовательности: {max1}");