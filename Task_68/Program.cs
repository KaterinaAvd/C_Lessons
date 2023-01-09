//Task_68

int rec(int m, int n)
{
        if (m == 0) 
            return n + 1;
        else if (n == 0 && m > 0) 
            return rec(m - 1, 1);
        else
            return rec(m - 1, rec(m, n - 1));
}

Console.Clear();
Console.WriteLine("Введите первое натуральное число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A (m, n) = {rec(m, n)}");
