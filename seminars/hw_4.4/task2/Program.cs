// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while(numb != 0)
{
    sum = sum + numb % 10;
    numb = numb / 10;
}

Console.WriteLine(sum);
