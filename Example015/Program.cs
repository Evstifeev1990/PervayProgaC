﻿// string[,] table = new string[2, 5];

// for(int rows = 0; rows<2; rows++)
// {
//     for (int columns = 0; columns<5; columns++)
//     {
//         Console.Write($"-{table[rows, columns]}-");
//     }
// }


void PrintArray(int[,] matr) 
{
    for(int rows = 0; rows<matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns<matr.GetLength(1); columns++)
        {

            Console.Write($"{matr[rows, columns]} ");
        }
    Console.WriteLine();
    }
}

void RandomArray(int[,] matr) 
{
    for(int rows = 0; rows<matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns<matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().Next(1,10);
            Console.Write($"{matr[rows, columns]} ");
        }
    Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
Console.WriteLine();
RandomArray(matrix);
