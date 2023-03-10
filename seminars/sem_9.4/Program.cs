// // Задача 65: Задайте значения M и N
// // Напишите программу, которая выведет все натуральные числа
// // в промежутке от M до N.
// // M = 1; N = 5 -> "1, 2, 3, 4, 5"
// // M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Console.Write("Enter number m: ");
// int m = Convert.ToInt32(Console.ReadLine()); 

// Console.Write("Enter number n: ");
// int n = Convert.ToInt32(Console.ReadLine()); 

// int min = m;
// int max = n;
// if(n < m) 
// {
//     min = n;
//     max = m;
// }
// int i = min;

// int RecForNatNumbersFrom(int max, int i)
// {
//     if(i == max)
//     {
//         Console.WriteLine(i);
//         return i;
//     }

//     Console.Write($"{i} ");

//     return RecForNatNumbersFrom(max, i + 1);
// }

// RecForNatNumbersFrom(max, i);



// // Through the lines
// // Console.Clear();

// // System.Console.WriteLine(ReturnNumber(PutNumber("Введите m : "),PutNumber("Введите n : ")));

// // int PutNumber(string message)
// // {
// //   System.Console.WriteLine(message);
// //   int number = Convert.ToInt32(Console.ReadLine());
// //   return number;
// // }

// // string ReturnNumber(int m, int n)
// // {
// //   if (m == n) return n + "";
// //   else
// //     return m + " " + ReturnNumber(m + 1, n);

// // }

