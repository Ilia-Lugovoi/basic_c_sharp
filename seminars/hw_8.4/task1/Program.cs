// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int rows = 3;
int columns = 4;
int[] limits = {-10, 11};

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
// Create TwoDim array
int[] arr1D = new int[array.GetLength(1)];

int[] BubbleSort(int[] arr)
{
    int n = arr.Length;
    bool swapped;

    do
    {
        swapped = false;
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                swapped = true;
            }
        }
        n--;
    } while (swapped);
    
    return arr;
}
// Sorting OneDim array

int[] TranslateRowToOneDim(int[,] arr2D, int row)
{
    int[] arr1D = new int[arr2D.GetLength(1)];
    for (int i = 0; i < arr2D.GetLength(1); i++)
    {
        arr1D[i] = arr2D[row, i];
    }
    return arr1D;
}
// Translate row from TwoDim array to OneDim array

int[,] TranslateOneDimToRow(int[] arr1D, int row, int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(1); i++)
    {
        arr2D[row, i] = arr1D[i];
    }

    return arr2D;
}
// Translate array to row

int[,] TwoDimSelectionSort(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr1D = BubbleSort(TranslateRowToOneDim(arr2D, i));
        }
        arr2D = TranslateOneDimToRow(arr1D, i, arr2D);
    }
    return arr2D;
}
// Sorting TwoDim array rows

array = TwoDimSelectionSort(array);

void ShowDuoArray(int[,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        
        Console.WriteLine();
    }
}
ShowDuoArray(array);
// Show TwoDim array