// Task_56

void FullMatrix(int[, ] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = new Random().Next(1, 101); // [1, 100]
            Console.Write($"{matrix[m, n]} \t");
        }
        Console.WriteLine();
    }
}


void MinSumRow(int[, ] matrix) 
{ 
    int[] minsum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
            minsum[i] = sum;
        }
        //Console.WriteLine($"{minsum[i]} \t"); //проверка сумм по строкам
    }
    int min = minsum[0], min1 = 0;
    for (int k = 1; k < minsum.Length; k++)
        if (min > minsum [k])
        {
            min = minsum [k];
            min1 = k;
        }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {min1+1}");
}


Console.Clear();
Console.Write("Введите размеры матрицы (через запятую): ");
int[] size = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
Console.WriteLine("Заданный массив: ");
FullMatrix(matrix);
MinSumRow(matrix);