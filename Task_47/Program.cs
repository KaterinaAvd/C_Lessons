// Task_47

void InputMatrix(double[, ] matrix)
{
    for (int m = 0; m <= 2; m++)
    {
        for (int n = 0; n <= 3; n++)
        {
            matrix[m, n] = Math.Round(new Random().NextDouble() * (100 - (-100)) + (-100), 2); // [-100, 100] 
            Console.Write($"{matrix[m, n]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Выводим матрицу 3х4 из случайных вещественных чисел:");
double[,] matrix = new double[3, 4];
InputMatrix(matrix);