// Напишите программу, которая будет принимать на вход числа и выводить, является ли второе число кратным первому
// Если второе число не кратно первому, то программа выводит остаток от деления

// int SplitTwDNumber(int numbToSplit, int[] rangeOfDifNumbs)
// {
//     for(int i = 0; i < rangeOfDifNumbs.Length; i++)
//     {
//         if(numbToSplit < rangeOfDifNumbs[i])
//         {
//             // return i; - n1
//             return numbToSplit - i * 10; // n2
//         }
//     }

//     return -1;
// }

double n1 = 2;//new Random().Next(1, 10);
double n2 = 4;//new Random().Next(0, 101);
double result = Math.Round(n2 / n1, 1);
double[] rangeOfNumbs = {0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9};
int i = 0;

Console.WriteLine(result);

while (i < rangeOfNumbs.Length)
{
    if(result - rangeOfNumbs[i] == Math.Round(result - rangeOfNumbs[i], 0))
    {
        Console.WriteLine(i);
        break;
    }
    i++;
}

if(i == 0)
{
    Console.WriteLine("Число 2 кратно числу 1!");
}
