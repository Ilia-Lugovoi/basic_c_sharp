string[,] table = new string[2,5];


// table[1, 2] = "World";
// table[0, 2] = "hello";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }

int[,] matrix = new int[3,4];

for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int colums = 0; colums < matrix.GetLength(1); colums++)
    {
        Console.Write($"{matrix[rows, colums]} ");
    }

    Console.WriteLine();
}
