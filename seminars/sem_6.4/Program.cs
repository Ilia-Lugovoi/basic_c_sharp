// Задача 39: Напишите программу, которая перевернёт одномерный массив
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

int[] RevertArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }

    return array;
}

int[] revAr = RevertArray(array);
Console.WriteLine(String.Join(" ", array));
