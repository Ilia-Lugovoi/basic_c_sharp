// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да


int[] array = {6, 7, 19, 345, -3};
int trueNumb = -3;

void NumbMembershipСheck(int[] array, int trueNumb)
{
    int i = 0;
    foreach (var numb in array)
    {
        if(numb == trueNumb)
        {
            i++;
        }
    }

    if(i > 0)
        Console.WriteLine("yes");
    else if(i == 0)
        Console.WriteLine("no");
}

NumbMembershipСheck(array, trueNumb);
