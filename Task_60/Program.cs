// Task_60

void FullMatrix(int[, , ] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int m = 0; m < matrix.GetLength(0); m++)
        {
            for (int n = 0; n < matrix.GetLength(1); n++)
            {
                matrix[m, n, k] = new Random().Next(1, 101); // [1, 100]
                Console.Write($"{matrix[m, n, k]}({m},{n},{k}) \t");
            }
        Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите размеры трехмерного массива (через запятую): ");
int[] size = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
int[, , ] matrix = new int[size[0], size[1], size[2]];
Console.WriteLine("Массив с индексами элементов: ");
FullMatrix(matrix);