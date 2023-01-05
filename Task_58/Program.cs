// Task_58

void FullMatrix1(int[, ] matrix1)
{
    for (int m1 = 0; m1 < matrix1.GetLength(0); m1++)
    {
        for (int n1 = 0; n1 < matrix1.GetLength(1); n1++)
        {
            matrix1[m1, n1] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix1[m1, n1]} \t");
        }
        Console.WriteLine();
    }
}

void FullMatrix2(int[, ] matrix2)
{
    for (int m2 = 0; m2 < matrix2.GetLength(0); m2++)
    {
        for (int n2 = 0; n2 < matrix2.GetLength(1); n2++)
        {
            matrix2[m2, n2] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix2[m2, n2]} \t");
        }
        Console.WriteLine();
    }
}

void RezaltMatrix(int[, ] matrix1, int[, ] matrix2) 
{ 
    int[, ] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int m = 0; m < matrix1.GetLength(0); m++)
    {
        for (int n = 0; n < matrix2.GetLength(1); n++)
        {
            matrix3[m, n] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[m, n] += matrix1[m, k] * matrix2[k, n];
            }
        Console.Write($"{matrix3[m, n]} \t");
        }
    Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матриц для умножения (через запятую): ");
int[] size = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
int[, ] matrix1 = new int[size[0], size[1]];
int[, ] matrix2 = new int[size[0], size[1]];
Console.WriteLine("Заданный массив_1: ");
FullMatrix1(matrix1);
Console.WriteLine("Заданный массив_2: ");
FullMatrix2(matrix2);
Console.WriteLine("Результирующий массив: ");
RezaltMatrix(matrix1, matrix2);