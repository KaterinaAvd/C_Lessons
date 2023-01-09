//Task_66

int rec(int M, int N)
{
    if (M == N)
        return N;
    return rec(M, N - 1) + N;
}

Console.Clear();
Console.WriteLine("Введите первое натуральное число:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число (оно должно быть больше первого)");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел между ними (включительно): {rec(M, N)}");