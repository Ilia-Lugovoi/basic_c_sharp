// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 78 -> третьей цифры нет
// 32679 -> 6

int n1 = 0, n2 = 0, n3 = 0;
int[] rangeOfTwD = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
int[] rangeOfThD = {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000};
int[] rangeOfFoD = {1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000};
int[] rangeOfFiD = {10000, 20000, 30000, 40000, 50000, 60000, 70000, 80000, 90000, 100000};
int[] rangeOfSiD = {100000, 200000, 300000, 400000, 500000, 600000, 700000, 800000, 900000, 1000000};
int[] rangeOfSeD = {1000000, 2000000, 3000000, 4000000, 5000000, 6000000, 7000000, 8000000, 9000000, 10000000};
int[] rangeOfEiD = {10000000, 20000000, 30000000, 40000000, 50000000, 60000000, 70000000, 80000000, 90000000, 100000000};
int[] rangeOfNiD = {100000000, 200000000, 300000000, 400000000, 500000000, 600000000, 700000000, 800000000, 900000000, 1000000000};
int temp1Numb = 0;


Console.WriteLine("Программа по выводу третей цифры числа");

Console.Write("Ввод числа: ");
int userNumb = Convert.ToInt32(Console.ReadLine());

int findThirdDig(int userNumb, int n3, int[] rangeOfDig1, int[] rangeOfDig2, int[] rangeOfDig3)
{
    for(int i1 = 0; i1 < rangeOfDig1.Length; i1++)
    {
        if(userNumb < rangeOfDig1[i1])
        {
            int n1 = 0;
            n1 = i1;
            int temp1Numb = 0;
            temp1Numb = userNumb - n1 * rangeOfDig1[0];
            for(int i2 = 0; i2 < rangeOfDig2.Length; i2++)
            {
                if(temp1Numb < rangeOfDig2[i2])
                {
                    int n2 = 0;
                    n2 = i2;
                    int temp2Numb = 0;
                    temp2Numb = temp1Numb - n2 * rangeOfDig2[0];
                    for(int i = 0; i < rangeOfDig3.Length; i++)
                    {
                        if(temp2Numb < rangeOfDig3[i])
                        {
                            Console.WriteLine(i);
                            return i;
                        }
                    }
                }
            }
        }
    }
    return -1;
}

if(userNumb < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else if(userNumb < 1000)
{
    for(int i1 = 0; i1 < rangeOfThD.Length; i1++)
    {
        if(userNumb < rangeOfThD[i1])
        {
            n1 = i1;
            temp1Numb = userNumb - n1 * 100;

            for(int i = 0; i < rangeOfTwD.Length; i++)
            {
                if(temp1Numb < rangeOfTwD[i])
                {
                    n2 = i;
                    n3 = temp1Numb - i * 10;
                    break;
                }
            }
            break;
        }
    }
    Console.WriteLine(n3);
}
else if(userNumb < 10000)
{
    n3 = findThirdDig(userNumb, n3, rangeOfFoD, rangeOfThD, rangeOfTwD);
}
else if(userNumb < 100000)
{
    n3 = findThirdDig(userNumb, n3, rangeOfFiD, rangeOfFoD, rangeOfThD);
}
else if(userNumb < 1000000)
{
    n3 = findThirdDig(userNumb, n3, rangeOfSiD, rangeOfFiD, rangeOfFoD);
}
else if(userNumb < 10000000)
{
    n3 = findThirdDig(userNumb, n3, rangeOfSeD, rangeOfSiD, rangeOfFiD);
}
else if(userNumb < 100000000)
{
    n3 = findThirdDig(userNumb, n3, rangeOfEiD, rangeOfSeD, rangeOfSiD);
}
else if(userNumb < 1000000000)
{
    n3 = findThirdDig(userNumb, n3, rangeOfNiD, rangeOfEiD, rangeOfSeD);
}
