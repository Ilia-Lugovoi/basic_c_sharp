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

// // Задача 57: Составить частотный словарь элементов двумерного массива.
// // Частотный словарь содержит информацию о том, сколько раз встречается элемент ВД

// Console.Write("Enter how many rows do you want: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter how many columns do you want: ");
// int columns = Convert.ToInt32(Console.ReadLine());

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
// int[,] array2D = CreateTwoDimArrayOfRandNumbs(rows, columns, limits); 
// // Создали двумерный массив

// int[] ConvertTo1DArray(int[,] array)
// {
//     int rows = array.GetLength(0);
//     int cols = array.GetLength(1);
//     int[] result = new int[rows * cols];
//     int index = 0;

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             result[index] = array[i, j];
//             index++;
//         }
//     }

//     return result;
// }
// int[] array1D = ConvertTo1DArray(array2D);
// // Перевели числа в одномерный массив

// void MinimaxSort(int[] array)
// {
//     int n = array.Length;

//     for (int i = 0; i < n / 2; i++)
//     {
//         int minIndex = i;
//         int maxIndex = i;

//         for (int j = i; j < n - i; j++)
//         {
//             if (array[j] < array[minIndex])
//             {
//                 minIndex = j;
//             }
//             if (array[j] > array[maxIndex])
//             {
//                 maxIndex = j;
//             }
//         }

//         int temp = array[i];
//         array[i] = array[minIndex];
//         array[minIndex] = temp;

//         if (maxIndex == i)
//         {
//             maxIndex = minIndex;
//         }

//         temp = array[n - i - 1];
//         array[n - i - 1] = array[maxIndex];
//         array[maxIndex] = temp;
//     }
// }
// MinimaxSort(array1D);
// // Отсортировали одномерный массив

// void ElementCount(int number, int[] array1D)
// {
//     int count = 0;
//     for (int i = 0; i < array1D.Length; i++)
//     {
//         if(number == array1D[i])
//             count++;
//     }
//     Console.WriteLine($"{number} meets {count} times");
// }
// void PrintCounts(int[] array1D)
// {
//     for (int i = 0; i < array1D.Length; i++)
//     {
//         if(i == 0)
//         {
//             ElementCount(array1D[i], array1D);
//         }
//         else if(array1D[i] != array1D[i - 1])
//         {
//             ElementCount(array1D[i], array1D);
//         }
//     }
// }
// // Вывели частотный словарь

// PrintCounts(array1D);
