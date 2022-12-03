// Task_Bonus_2
Console.Clear();
Console.Write("Введите количество кустов на грядке: "); 
int n = Convert.ToInt32(Console.ReadLine());
int maxSum = 0; 
int[] array = new int[n]; 
for (int i = 0; i < array.Length; i++)
{     
    Console.Write($"Введите количество ягод на {i+1} кусте: "); 
    array[i] = Convert.ToInt32(Console.ReadLine());  
}
for (int i = 1; i < array.Length - 1; i++) 
{     
    if (maxSum < array[i - 1] + array[i] + array[i + 1])         
    maxSum = array[i - 1] + array[i] + array[i + 1]; 
} 
if (maxSum < array[n - 1] + array[n - 2] + array[0])     
    maxSum = array[n - 1] + array[n - 2] + array[0]; 
if (maxSum < array[0] + array[1] + array[n - 1])     
    maxSum = array[0] + array[1] + array[n - 1]; 
Console.WriteLine($"Максимальное количество ягод: {maxSum}");