// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

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

// First Version

// Console.Write("Enter row of your number: ");
// int m = Convert.ToInt32(Console.ReadLine()) - 1;

// Console.Write("Enter column of your number: ");
// int n = Convert.ToInt32(Console.ReadLine()) - 1;

// if(m <= rows)
// {
//     Console.WriteLine(array[m,n]);
// }
// else
// {
//     Console.WriteLine("No such element");
// }

// m = 0;
// n = 0;

// Second Version

// Console.Write("Enter desired number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// foreach (int numb in array)
// {
//     if(numb == number)
//     {
//         count++;
//         Console.WriteLine($"Your number {number} has been found!");
//     }
// }
// if(count == 0)
// {
//     Console.WriteLine("There is no such number in the array");
// }
