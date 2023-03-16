// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


double[,] ReturnFloatMatrix(int rows, int columns)
{
    var rand = new Random();
    double[, ] myArray = new double[rows, columns];
    for (int i = 0; i < rows; i++) 
    {
        for(int j = 0; j<columns; j++)
        {
            myArray[i, j] = Math.Round((rand.NextDouble() * rand.Next(-10, 11)), 2);
             
        }

    }
    return myArray;
}
Console.Write("Please, enter quantity of rows and columns with space between: ");
string[] line = Console.ReadLine()!.Split(" ");
int rows = int.Parse(line[0]);
int columns = int.Parse(line[1]);

double[,] needArray = ReturnFloatMatrix(rows, columns);
for(int i = 0; i<rows; i++)
{
    for(int j = 0; j<columns; j++)
    {
        Console.Write($"{needArray[i,j]} ");
    }
    Console.WriteLine();
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

