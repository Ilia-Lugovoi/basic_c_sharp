// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
// 456 -> 5

Console.Write("Введите трёхзначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());

int secondDigOfNumb = (numb / 10) % 10; 

Console.WriteLine(secondDigOfNumb);
