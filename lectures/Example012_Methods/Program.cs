// Вид 1 - Выполняет Заготовленные Методы
// (Прибавить читаемости кода)
// void Method1()
// {
//     Console.WriteLine("Автор Илья");
// }

// Method1();



// Вид 2 - Принимает данные и с ними выполняет действия
// (Чтобы преобразовать что-либо и не сохранять это)
// void Method2(string msg, int count)
// {
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(msg);

//     }

// }

// Method2(msg: "Текст сообщения", count: 5);



// Вид 3 - Для поиска значений другими методами
// (Прибавить читаемости кода)
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine($"Текущий год: {year}");



// Вид 4 - Преобразовать и сохранить что-либо
// string Method4(int count, string c)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + c;
//     }

//     return result;
// }

// string res = Method4(10, "ty");
// Console.WriteLine(res);



// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 0; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }

//     Console.WriteLine();
// }



// ====== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r


// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     for (int i = 0; i < text.Length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);



int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

// PrintArray(arr);
SelectionSort(arr); // Сортировка методом выбора

PrintArray(arr);
