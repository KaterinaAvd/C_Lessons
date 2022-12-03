// Task_21
Console.Clear();
Console.WriteLine("Необходимо найти расстояние между точками А и В в трехмерном пространстве");
Console.WriteLine("Введите координаты точки А (х1, у1, z1):");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B (х2, у2, z2):");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());
double line = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2));
Console.WriteLine($"Расстояние между точками равно: {Math.Round(line,2)}");