// Task_43
Console.Clear();
Console.WriteLine("Введите коэффициенты прямой y = k1*x + b1");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициенты прямой y = k2*x + b2");
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = Convert.ToDouble((b2 - b1) / (k1 - k2));
double y = Convert.ToDouble((k1*((b2 - b1) / (k1 - k2)))+ b1);
Console.WriteLine($"Прямые пересекаются в точке ({x}; {y})");