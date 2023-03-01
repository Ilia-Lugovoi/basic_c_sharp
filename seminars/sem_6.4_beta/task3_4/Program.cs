// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N =  -> 0 1 1 2 3 5 8 13

// int finalNumb = 5;
// int sum = 0;
// int numb1 = 0;
// int numb2 = 1;
// sum1 = numb1 + numb2;
// sum2 = sum1(numb1 + numb2) + numb2;
// sum3 = sum2(numb1 + numb2 + numb2) + sum1(numb1 + numb2);

// for (int i = 1; i < length; i++)
// {
//     Console.Write(sum);
// }

// 


Console.Write("Enter the number of Fibonacci numbers: ");
int n = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;
int c;

Console.Write(a + " " + b + " ");

for (int i = 2; i < n; i++)
{
    c = a + b;
    a = b;
    b = c;

    Console.Write(c + " ");
}

Console.WriteLine();

