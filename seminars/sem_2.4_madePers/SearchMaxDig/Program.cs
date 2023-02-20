// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

// int findMax(int n1, int n2)
// {
//     int maxOfNumbs = n1;
//     if(n2 > maxOfNumbs)
//     {
//         maxOfNumbs = n2;
//     }

//     return maxOfNumbs;
// }

// int randNumb = new Random().Next(10, 100);
// Console.WriteLine(randNumb);

// int[] array = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};

// for(int i = 0; i < array.Length; i++)
// {
//     if(randNumb < array[i])
//     {
//         int n1 = i;
//         int n2 = randNumb - (n1 * 10);
//         int max = findMax(n1, n2);
//         Console.WriteLine(max);
//         break;
//     }
// }


int numb = new Random().Next(10, 100);
Console.WriteLine(numb);

int digit1 = numb / 10, digit2 = numb % 10;
int maxDigit = digit1;

if(digit2 > maxDigit){
    maxDigit = digit2;
}

Console.WriteLine(maxDigit);
