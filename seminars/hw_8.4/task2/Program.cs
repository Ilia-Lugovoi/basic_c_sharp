// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = 4;
int columns = 4;
int[] limits = {0, 11};

int[,] CreateTwoDimArrayOfRandNumbs(int rows, int columns, int[] limits)
{
    int[,] twoDimArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            twoDimArray[i, j] = new Random().Next(limits[0], limits[1]);
            Console.Write($"{twoDimArray[i, j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    return twoDimArray;
}
int[,] array = CreateTwoDimArrayOfRandNumbs(rows, columns, limits);
int[] arr1D = new int[array.GetLength(1)];
// Create TwoDim array & OneDim

int[] TranslateRowToOneDim(int[,] arr2D, int row)
{
    int[] arr1D = new int[arr2D.GetLength(1)];
    for (int i = 0; i < arr2D.GetLength(1); i++)
    {
        arr1D[i] = arr2D[row, i];
    }
    return arr1D;
}
int FindSum(int[] arr)
{
    int minSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        minSum += arr[i];
    }

    return minSum;
}

int FindMinRow(int[,] arr2D)
{
    int minSum = FindSum(TranslateRowToOneDim(arr2D, 0));
    int minRow = 0;
    int tempSum;
    for (int i = 1; i < arr2D.GetLength(0); i++)
    {
        tempSum = FindSum(TranslateRowToOneDim(arr2D, i));
            
        if(tempSum < minSum)
        {
            minSum = tempSum;
            minRow = i;
        }
    }

    return minRow + 1;
}
// Translate Row 1 to OneDim
// Find sum of OneDim = minSum
// Find new sum & compare with minSum -->> loop


Console.WriteLine($"The row with the smallest sum of elements: {FindMinRow(array)}");
// Show number of row
