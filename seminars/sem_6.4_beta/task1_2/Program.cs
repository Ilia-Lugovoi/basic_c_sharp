// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Examination of true triangle!");

Console.Write("Write side a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Write side b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Write side c: ");
int c = Convert.ToInt32(Console.ReadLine());


if(a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Exam for triangle was passed!!!)");
}
else
{
    Console.WriteLine("Exam for triangle was failed!!!(( ");
}
