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

// Задача 40: Программа проверки на существоание треугольника 

Console.WriteLine("Examination of true triangle!");

Console.Write("Write side a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Write side b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Write side c: ");
int c = Convert.ToInt32(Console.ReadLine());


if(a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Exam for triangle was passed!!!)");
}
else
{
    Console.WriteLine("Exam for triangle was failed!!!(( ");
}

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Write("Write numb pls: ");
int numb = Convert.ToInt32(Console.ReadLine());
string numbs = string.Empty;

while(numb > 0)
{
    numbs = numb % 2 + numbs;
    numb = numb / 2;
}

Console.WriteLine(numbs);

//
// static void Task02()
// {
//     int number = PromptInput("Введите число: ");
//     int[] array = new int[Count(number)];

//     static int[] ReverseArray(int[] array)
//     {

//     }

//     static void PrintArray(int[] array)
//     {

//     }

//     int Count(int count)
//     {
    
//     }

//     int[] GetNumber(int[] array, int number)
//     {

//     }

// }
