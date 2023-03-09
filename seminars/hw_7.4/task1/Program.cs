// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Enter how many rows do you want: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter how many columns do you want: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] limits = {-100, 101};

double[,] CreateTwoDimArrayOfRandNumbs(int rows, int columns, int[] limits)
{
    double[,] twoDimArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            twoDimArray[i, j] = new Random().Next(limits[0], limits[1]);
            twoDimArray[i, j] = twoDimArray[i, j] / 10;
            Console.Write($"{twoDimArray[i, j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    return twoDimArray;
}

double[,] array = CreateTwoDimArrayOfRandNumbs(m, n, limits);
