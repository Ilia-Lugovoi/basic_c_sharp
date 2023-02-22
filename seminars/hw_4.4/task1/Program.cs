// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int aToDeg = 1;

for (int i = 0; i < b; i++)
{
    aToDeg = aToDeg * a;
}

Console.WriteLine(aToDeg);
