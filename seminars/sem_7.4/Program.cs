// /*
// Задача 48. Задайте двумерный массив размера m на n,
// Каждый элемент массива находится по формуле: A = m + n
// Выведите полученный массив на экран
// */

// Console.Write("Enter how many rows do you want: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter how many columns do you want: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] CreateTwoDimArrayOfRandNumbs(int rows, int columns)
// {
//     int[,] twoDimArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             twoDimArray[i, j] = i + j;
//             Console.Write($"{twoDimArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }

//     Console.WriteLine();
//     return twoDimArray;
// }

// int[,] array = CreateTwoDimArrayOfRandNumbs(m, n);

// // Задача 49: Задайте двумерный массив
// // Найдите элементы, у которых оба индекса чётные,
// // и замените эти элементы на их квадраты.
// // Например, изначально массив выглядел вот так:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Новый:
// // 1 4 7 2
// // 5 81 2 9
// // 8 4 2 4

// Console.Write("Enter how many rows do you want: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter how many columns do you want: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] limits = {-10, 11};

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

// int[,] array = CreateTwoDimArrayOfRandNumbs(m, n, limits);

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     if((i + 1) % 2 == 0)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if((j + 1) % 2 == 0)
//                 array[i, j] = array[i, j] * array[i, j];
//         }
//     }
//     for (int k = 0; k < array.GetLength(1); k++)
//     {
//         Console.Write($"{array[i, k]} ");
//     }
//     Console.WriteLine();
// }

// // Задача 51: Задайте двумерный массив.
// // Найдите сумму элементов, находящихся на главной диагонали
// // с индексами (0,0); (1;1) и т.д.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Сумма элементов главной диагонали: 1+9+2 = 12


// Console.Write("Enter how many rows do you want: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter how many columns do you want: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] limits = {-10, 11};

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

// int[,] array = CreateTwoDimArrayOfRandNumbs(m, n, limits);

// int sum = 0;

// for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
// {
//     sum += array[i, i];
//     Console.Write($"{sum} ");
// }

// Console.WriteLine();
