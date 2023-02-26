// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Enter how many elements of the array you want to create: ");
int lengthOfArray = Convert.ToInt32(Console.ReadLine());
int sum = 0;

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

for (int i = 1; i < array.Length; i++)
{
    if(i % 2 != 0)
        sum+= array[i];
}

Console.WriteLine(sum);
