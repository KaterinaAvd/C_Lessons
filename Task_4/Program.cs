Console.Clear();
Console.Write("Введите целое число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число C: ");
int c = Convert.ToInt32(Console.ReadLine());
int d = a;
if(b >= d) 
{
    d = b;
}
if(c>=d)
{
    d = c;
    Console.WriteLine(d);
}
else
{
    Console.WriteLine(d);
}