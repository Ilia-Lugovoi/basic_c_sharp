// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Write("Enter how many elements of the array you want to create: ");
int lengthOfArray = Convert.ToInt32(Console.ReadLine());

int[] limits = {-100, 101};
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
int max = array[0];
int min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    else if(array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine(max - min);
