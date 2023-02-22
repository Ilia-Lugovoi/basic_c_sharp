// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double[] a = new double[3];
Console.Write("Введите x от А: ");
a[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y от А: ");
a[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z от А: ");
a[2] = Convert.ToDouble(Console.ReadLine());

double[] b = new double[3];
Console.Write("Введите x от B: ");
b[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y от B: ");
b[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z от А: ");
b[2] = Convert.ToDouble(Console.ReadLine());

double difX = b[0] - a[0];
double difY = b[1] - a[1];
double difZ = b[2] - a[2];

double d = Math.Sqrt(Math.Pow(difX, 2) + Math.Pow(difY, 2) + Math.Pow(difZ, 2));

Console.WriteLine($"Ответ: {Math.Round(d, 2)}");
