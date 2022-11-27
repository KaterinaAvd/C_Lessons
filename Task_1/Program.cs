Console.Clear();
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a >= b) 
{
    Console.Write($"max = {a}");
}
else
{
    Console.Write($"max = {b}");
}