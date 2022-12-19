// Task_52

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


void AverageColumn(int[, ] matrix)
{
     for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0, sum = 0;   
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i,j];
            average = Math.Round(sum / matrix.GetLength(0),2);
        }
        Console.WriteLine($"Среднее арифметическое элементов {j+1} столбца: {average}");
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы (через запятую): ");
int[] size = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
FullMatrix(matrix);
AverageColumn(matrix);