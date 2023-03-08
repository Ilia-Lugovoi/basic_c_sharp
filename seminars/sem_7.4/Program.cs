/*
Задача 48. Задайте двумерный массив размера m на n,
Каждый элемент массива находится по формуле: A = m + n
Выведите полученный массив на экран
*/

Console.Write("Enter how many rows do you want: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter how many columns do you want: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateTwoDimArrayOfRandNumbs(int rows, int columns)
{
    int[,] twoDimArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            twoDimArray[i, j] = i + j;
            Console.Write($"{twoDimArray[i, j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    return twoDimArray;
}

int[,] array = CreateTwoDimArrayOfRandNumbs(m, n);
