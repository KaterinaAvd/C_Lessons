// Task_50

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


void ErrMatrix(int[, ] matrix, int i, int j)
{
     if (i >= matrix.GetLength(0) || j >= matrix.GetLength(1) || i < 0 || j < 0)
        Console.WriteLine("Элемент с такими координатами в матрице отсутствует");
    else
        Console.WriteLine($"Искомый элемент: {matrix[i, j]}");
}


Console.Clear();
Console.Write("Введите размеры матрицы (через запятую): ");
int[] size = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
FullMatrix(matrix);
Console.Write("Введите позицию элемента, который нужно найти (через запятую): ");
int[] position = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
ErrMatrix(matrix, position[0] - 1, position[1] - 1);