// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Первый способ:

int weekDays = 7;
int userAnswer = 0;

while(true){
    Console.Write("Введите день недели, чтобы проверить - выходной он или нет: ");
    userAnswer = Convert.ToInt32(Console.ReadLine());
    if(userAnswer > weekDays || userAnswer <= 0)
    {
        Console.WriteLine("Введите день недели: число от 1 до 7");
        continue;
    }
    break;
}

if(userAnswer < 6)
    Console.WriteLine("нет");
else
    Console.WriteLine("да");

// Второй способ:

// while(true)
// {
//     Console.Write("Введите день недели, чтобы проверить - выходной он или нет: ");
//     int userAnswer = Convert.ToInt32(Console.ReadLine());

//     if(userAnswer == 6 || userAnswer == 7)
//     {
//         Console.WriteLine("да");
//         break;
//     }
//     if(userAnswer < 6 && userAnswer > 0)
//     {
//         Console.WriteLine("нет");
//         break;
//     }
//     else
//     {
//         Console.WriteLine("Введите день недели от 1 до 7");
//         continue;
//     }
// }
