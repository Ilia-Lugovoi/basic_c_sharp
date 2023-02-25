// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Enter how many elements of the array you want to create: ");
int lengthOfArray = Convert.ToInt32(Console.ReadLine());

int[] limits = {1, 10};
int[] CreateArrayOfRandNumbs(int arrayLength, int[] limits)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(limits[0], limits[1]);
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
    return array;
}

int[] array = CreateArrayOfRandNumbs(lengthOfArray, limits);

if(lengthOfArray % 2 == 0)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] * array[lengthOfArray - 1]);
        lengthOfArray--;
        if(lengthOfArray - 1 == i)
        {
            break;
        }
    }
}
else
{
    int tempLength = (lengthOfArray / 2);
    lengthOfArray = lengthOfArray - 1;

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] * array[lengthOfArray]);
        lengthOfArray--;
        if(lengthOfArray - 1 == i)
        {
            break;
        }
    }

    Console.WriteLine(array[tempLength]);

}

