// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[,] FillSpiralArray(int size)
{
    int[,] array = new int[size, size];
    int value = 1;
    int row = 0;
    int col = 0;
    
    while (value <= size * size)
    {
        for (int i = col; i < size - col; i++)
        {
            array[row, i] = value++;
        }
        row++;

        for (int i = row; i < size - row + 1; i++)
        {
            array[i, size - col - 1] = value++;
        }
        col++;

        for (int i = size - col - 1; i >= col - 1; i--)
        {
            array[size - row, i] = value++;
        }

        for (int i = size - row - 1; i >= row; i--)
        {
            array[i, col - 1] = value++;
        }
    }
    
    return array;
}
int[,] array = FillSpiralArray(Prompt("Enter size:"));

void ShowArray(int[,] arr, string msg = "")
{
    Console.WriteLine(msg);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
ShowArray(array, "Spiral array:");
