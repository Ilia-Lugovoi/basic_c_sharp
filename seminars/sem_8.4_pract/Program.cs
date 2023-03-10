﻿void ShowDuoArray(int[,] arr) // Вывод массива на экран.
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

int[,] arr = FillArray(4, 4);
ShowDuoArray(arr);

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

Console.ReadLine();

/*
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
*/