// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// int randNumb = new Random().Next(100, 1000);
// int n1 = 0;
// int n2 = 0;
// int n3 = 0;
// int newNumbOfTwoDig = 0;
// int desiredTwoDigNumb = 0;
// int[] arrayForThreeDigNumbs = {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000};
// int[] arrayForTwoDigNumbs = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};

// Console.WriteLine(randNumb);

// for(int i1 = 0; i1 < arrayThreeDigNumb.Length; i1++)
// {
//     if(randNumb < arrayThreeDigNumb[i1])
//     {
//         n1 = i1;
//         int twoDigNumb = randNumb - n1 * 100;
//         for(int i2 = 0; i2 < arrayTwoDigNumb.Length; i2++){
//             if(twoDigNumb < arrayTwoDigNumb[i2])
//             {
//                 n2 = i2;
//                 n3 = twoDigNumb - (n2 * 10);
//                 break;
//             }
//         }
//         int desiredTwoDigNumb = n1 * 10 + n3;
//         Console.WriteLine(desiredTwoDigNumb);
//         break;
//     }
// }

int TakeDigFromTwDNumb(int twDNumb, int[] rangeOfTwDNumbs)
{
    for(int i = 0; i < rangeOfTwDNumbs.Length; i++)
    {
        if(twDNumb < rangeOfTwDNumbs[i])
        {
            // return i; - n1
            return twDNumb - i * 10; // n2
        }
    }

    return -1;
}

int randNumb = new Random().Next(100, 1000);
int n1 = 0, n3 = 0;
int tempTwDNumb = 0;
int desiredTwoDigNumb = 0;
int[] rangeOfThD = {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000};
int[] rangeOfTwD = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};

Console.WriteLine(randNumb);

// Процесс вычленения из трёхзначного числа второй цифры

for(int i = 0; i < rangeOfThD.Length; i++)
{
    if(randNumb < rangeOfThD[i])
    {
        if(i == 0)
        {
            Console.WriteLine("Введите трёхзначное число");
            break;
        }

        n1 = i;
        tempTwDNumb = randNumb - n1 * 100;

        n3 = TakeDigFromTwDNumb(tempTwDNumb, rangeOfTwD);
        break;
    }
}

desiredTwoDigNumb = n1 * 10 + n3; 
Console.WriteLine(desiredTwoDigNumb);
