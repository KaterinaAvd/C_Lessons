// Task_25
Console.Clear();
Console.WriteLine("Необходимо возвести число А в натуральную степень В");
Console.Write("Введите число А: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int b = Convert.ToInt32(Console.ReadLine());
double a1 = 1;
int i = 1;
while (i <= b)
{
    a1 = a1 * a;
    i++;
}
Console.WriteLine($"{a} в степени {b} равно {Math.Round(a1,4)}");