// Напишите программу, которая принимает  на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 14 - no
// 46 - no
// 161 - yes

int n1 = 7;
int n2 = 23;

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if(number % n1 == 0 && number % n2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
