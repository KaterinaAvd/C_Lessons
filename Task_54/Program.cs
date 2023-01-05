// Task_54

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


void StreamlineRow(int[, ] matrix)
{ 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] >= matrix[i, k])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
            Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы (через запятую): ");
int[] size = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальная матрица: ");
FullMatrix(matrix);
Console.WriteLine("Упорядоченная матрица: ");
StreamlineRow(matrix);