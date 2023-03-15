// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int rows = 2;
// int columns = 2;
// int[] limits = {0, 11};

// int[,] CreateTwoDimArrayOfRandNumbs(int rows, int columns, int[] limits)
// {
//     int[,] twoDimArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             twoDimArray[i, j] = new Random().Next(limits[0], limits[1]);
//             Console.Write($"{twoDimArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }

//     Console.WriteLine();
//     return twoDimArray;
// }

int[,] matrix1 = {
    {2, 4},
    {3, 2}
};          // CreateTwoDimArrayOfRandNumbs(rows, columns, limits);
int[,] matrix2 = {
    {3, 4},
    {3, 3}
};          // CreateTwoDimArrayOfRandNumbs(rows, columns, limits);
// Create TwoDim arrays 1 & 2

int[,] FindSumOfMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}

while(true)
{
    if(matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        int[,] sumOfMatrix = FindSumOfMatrix(matrix1, matrix2);
        Console.WriteLine("Matrix product: ");
        for (int i = 0; i < sumOfMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < sumOfMatrix.GetLength(1); j++)
            {
                Console.Write(sumOfMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        break;
    }
    else
    {
        Console.WriteLine("ERROR");
    }
}
