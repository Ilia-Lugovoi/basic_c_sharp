// // Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]

// int [] arr = {1,2,3,4,5};

// for (int i = 0; i < arr.Length / 2; i++)
// {   
//     (arr[i], arr[arr.Length-i -1]) = (arr[arr.Length-i-1], arr[i]);
//     Console.WriteLine($"{arr[i]}");
// }
// for (int i = arr.Length / 2; i < arr.Length; i++)
// {   
//     Console.WriteLine($"{arr[i]}");
// }


// // int[] array = {1, 2, 3, 4, 5};
// // int tempInd = 0;
// // int count = 1;

// // for (int i = 0; i < array.Length; i++)
// // {
// //     tempInd = array[i];
// //     array[i] = array[array.Length - count];
// //     array[array.Length - count] = tempInd;
// //     if(count != 4)
// //         count++;
// //     Console.Write($"{array[i]} ");
// // }
// // Console.WriteLine(" ");

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

// каждая сторона треугольника меньше суммы двух других сторон

// int[] numbs = new int[3];
// int score = 0;
// for (int i = 0; i < 3; i++)
// {
//     Console.Write("Enter number ");
//     numbs[i] = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine("");

// for (int i = 0; i < numbs.Length; i++)
// {
//     for (int j = 0; j < numbs.Length; j++)
//     {
//         if(numbs[0] < numbs[i] + numbs[j])
//         score++;
//     }
// }
//     if(numbs[0] < numbs[1] + numbs[2])
//         score++;
//     if(numbs[0] < numbs[1] + numbs[2])
//         score++;
//     if(numbs[0] < numbs[1] + numbs[2])
//         score++;

// if(score == 3)
//     Console.WriteLine("He can!");
// else
//     Console.WriteLine("He can't!");


// int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9}; // столбец

// foreach (var item in nums)
// {
//     Console.WriteLine(item);
// }

// int[,] nums2 = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}, {0, 4, 2}};

// // int[,] nums3 = new int[4, 3];

// // foreach (var item in nums2)
// // {
// //     Console.WriteLine(item);
// // }

// for (int i = 0; i < nums2.GetLength(0); i++)
// {
//     for (int j = 0; j < nums2.GetLength(1); j++)
//     {
//         Console.Write($"{nums2[i, j]} ");
//     }
//     Console.WriteLine(" ");
// }
