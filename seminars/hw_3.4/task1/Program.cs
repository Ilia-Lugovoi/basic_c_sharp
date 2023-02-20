// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write("Введите 5-значное число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int n1 = numb / 10000;

if(n1 > 10 || n1 < 1)
{
    while(true)
    {
        Console.Write("Введите 5-значное число: ");
        numb = Convert.ToInt32(Console.ReadLine());
        n1 = numb / 10000;

        if(n1 > 10 || n1 < 1)
            continue;
        else
            break;
    }
}

n1 = numb / 10000;
int n2 = (numb % 10000) / 1000;
int n4 = (numb % 100) / 10;
int n5 = numb % 10;

if(n1 == n5 && n2 == n4)
    Console.WriteLine("Палиндром!");
else
    Console.WriteLine("Не палиндром");
