﻿string[,] table = new string[2,5];


table[1, 2] = "World";
table[0, 2] = "hello";

for (int rows = 0; rows < 2; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}
