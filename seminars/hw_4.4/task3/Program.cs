// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] ar = new int[8];

for (int i = 0; i < ar.Length; i++)
{
    ar[i] = new Random().Next(0, 101);
    Console.Write($"{ar[i]} ");
}

Console.WriteLine(" ");
