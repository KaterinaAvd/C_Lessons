// Task_29
Console.Clear();
int[] array = new int[8];
int i = 0;
while (i <= 7)
{
    Console.Write($"Введите {i+1} элемент массива: ");     
    array[i] = Convert.ToInt32(Console.ReadLine());  
    i++;
}
Console.WriteLine($"[{string.Join(", ", array)}]");