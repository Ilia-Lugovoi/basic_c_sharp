// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double DoubNumberRequest(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double k1 = DoubNumberRequest("Enter k1 : ");
double b1 = DoubNumberRequest("Enter b1 : ");
double k2 = DoubNumberRequest("Enter k2 : ");
double b2 = DoubNumberRequest("Enter b2 : ");

double x = (b1 - b2) / (k2  - k1);
double y = k1 * x + b1;

Console.WriteLine($"({x}; {y})");
