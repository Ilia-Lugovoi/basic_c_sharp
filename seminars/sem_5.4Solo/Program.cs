// // Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// // Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

// int[] randNums = new int[12];
// int sumPos = 0;
// int sumNeg = 0;

// for (int i = 0; i < randNums.Length; i++)
// {
//     randNums[i] = new Random().Next(-9, 10);

//     if(randNums[i] > 0)
//     {
//         sumPos = sumPos + randNums[i];
//     }
//     else if(randNums[i] < 0)
//     {
//         sumNeg = sumNeg + randNums[i];
//     }

//     Console.WriteLine(randNums[i]);
// }

// Console.WriteLine(sumPos);
// Console.WriteLine(sumNeg);


// // Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array1 = {-4, -8, 8, 2};
// int[] arrayNew = new int[4];

// for (int i = 0; i < array1.Length; i++)
// {
//     arrayNew[i] = array1[i] * -1;
//     Console.WriteLine(arrayNew[i]);
// }


// // Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, 3] -> да

// int[] ar = new int[5];
// for (int i = 0; i < ar.Length; i++)
// {
//     Console.Write("Введите число в массив: ");
//     ar[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.Write("Введите своё число на проверку: ");
// int givenNumb = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// for (int i = 0; i < ar.Length; i++)
// {
//     if(ar[i] == givenNumb)
//     {
//         Console.WriteLine("да");
//         count++;
//         break;
//     }
    
// }

// if(count == 0)
//    Console.WriteLine("нет");



// MUST SEE! :> D

// // string s = "Hello World";
// // string s1 = "Hello";
// // string s2 = "World";

// // int[] nums = {1, 2, 3, 4, 5};

// // string s3 = string.Concat(s1, s2);
// // string s3 = s1 + " " + s2;
// // Console.WriteLine(s3);
// // // конкатинация (сложение строк)

// // string s5 = string.Join("-!-", nums); // объединение коллекции данных 
// // (Из массива в строку)

// // string s = "1, 2, 3, 4, 5, 6, 7";

// // foreach (var item in s)
// // {
// //     Console.WriteLine(item);
// // }

// // Console.WriteLine(s5);

// string s = "1, 2, 3, 4, 5, 6, 7";

// // string[] numbs = s.Split(" ");
// // Замена одного элемента на другой

// string[] numbs = s.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
// // (Разбивает строку на элементы)

// int[] n = numbs.Select(Int32.Parse).ToArray();
// // Создание массива из выходной последовательности

// foreach (var item in numbs)
// {
//     Console.WriteLine(item);
// }

// string s10 = "14, 21, 23, 54, 45, 66, 97";
// int[] num1 = Array.ConvertAll(s10.Split(), int.Parse);

// // 1) string s3 = string.Concat(s1, s2);
// // (Конкатинация (сложение строк))

// // 2) string s5 = string.Join("-!-", nums);
// // (Вывод массива в строку)

// // 3) string[] numbs = s.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
// // ((Разбивает строку на элементы), а выбранные элементы - это разделитель)

// // 4) int[] n = numbs.Select(Int32.Parse).ToArray());
// // (Создание массива из выходной последовательности)

