// Напишите программу, которая будет принимать на вход числа и выводить, является ли второе число кратным первому
// Если второе число не кратно первому, то программа выводит остаток от деления

Console.Write("Введите число 1: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

double remainder = numb1 % numb2;

if(numb2 % numb1 == 0)
{
    Console.WriteLine("Число 2 кратно числу 1");
}
else
{
    Console.WriteLine(remainder);
}
