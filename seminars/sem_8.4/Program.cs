// // Задача 53: Задайте двумерный массив.
// // Напишите программу, которая поменяет местами первую и последнюю строку массива

// Console.Write("Enter how many rows do you want: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter how many columns do you want: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[] limits = {-100, 101};

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

// int[,] array = CreateTwoDimArrayOfRandNumbs(rows, columns, limits);

// int[] temp = new int[columns];

// for (int i = 0; i < columns; i++)
// {
//     temp[i] = array[0, i];
//     array[0, i] = array[rows - 1, i];
//     array[rows - 1, i] = temp[i];
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(array);

// // Задача 55: Задайте двумерный массив
// // Напишите программу, которая заменяет строки на столбцы.
// // В случае, если это невозможно, программа должна вывести сообщение для пользователя

// Console.Write("Enter how many rows do you want: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter how many columns do you want: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[] limits = {-100, 101};

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

// int[,] array = CreateTwoDimArrayOfRandNumbs(rows, columns, limits);
// int[,] newArray = new int[rows, columns];

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// if(rows != columns)
// {
//     Console.WriteLine("Can't be replaced");
// }
// else if(rows == columns)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < rows; j++)
//         {
//             newArray[i, j] = array[j, i];
//             newArray[j, i] = array[i, j];
//         }
//     }
//     PrintArray(newArray);
// }

