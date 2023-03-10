void ShowDuoArray(int[,] arr) // Вывод массива на экран.
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
    }
}
Console.Write("Enter how many rows do you want: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter how many columns do you want: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[] limits = {-10, 11};
int[,] FillArray(int rows, int columns, int[] limits)
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
int[,] arr = FillArray(rows, columns, limits);

int[] FindMinEl(int[,] arr)
{
    int minValue = arr[0, 0];
    int[] indexMinValue = new int[2];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (minValue > arr[i, j])
            {
                minValue = arr[i, j];
                indexMinValue[0] = i;
                indexMinValue[1] = j;
            }

        }
    }
    return indexMinValue;
}

void DeleteRowsColumns(int[,] arr, int[] index)
{
    int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int a = 0, b = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (index[0] == i) continue;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (index[1] == j) continue;

            newArr[a, b] = arr[i, j];
            b++;
        }
        a++;
        b = 0;
    }
    ShowDuoArray(newArr);
}

int[] indexMinValue = FindMinEl(arr);
DeleteRowsColumns(arr, indexMinValue);

Console.WriteLine();

/*
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
*/
