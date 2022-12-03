// Task_19
Console.Clear();
Console.WriteLine("Введите целое пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 10 == n / 10000 && (n / 10) % 10 == (n / 1000) % 10)
    Console.WriteLine($"ДА! Число {n} палиндром");
else 
    Console.WriteLine($"НЕТ! Число {n} НЕ палиндром");