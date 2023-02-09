// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // m = 3, n = 4.

// // 0,5 7 -2 -0,2

// // 1 -3,3 8 -9,9

// // 8 7,8 -7,1 9


// double[,] FillMatrixWithRandoms(int rows, int columns, int leftrange, int rightrange)
// {
//     Random rand = new Random();

//     double[,] matr = new double[rows, columns];
//     {
//         for (int i = 0; i < matr.GetLength(0); i++)
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                 matr[i, j] = Math.Round(rand.Next(leftrange, rightrange + 1) + rand.NextDouble(), 2);
//             }
//         }
//     }
//     return matr;
// }

// void PrintMatrix(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int InputNumber(string str)  // считывает введенный текст от пользователя, возвращает число, если текст - просит ввести еще раз 
// {
//     int number;
//     string? text;
//     while (true)
//     {
//         System.Console.WriteLine(str);
//         text = Console.ReadLine();

//         if (int.TryParse(text, out number))
//         {
//             break;
//         }
//         System.Console.WriteLine("Введено некорректное число");
//     }
//     return number;
// }

// int rows = InputNumber("Введите количество строк в массиве: ");
// int columns = InputNumber("Введите количество столбцов в массиве: ");
// double[,] array = FillMatrixWithRandoms(rows, columns, 0, 10);
// PrintMatrix(array);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }

    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int InputNumber(string str)  // считывает введенный текст от пользователя, возвращает число, если текст - просит ввести еще раз 
{
    int number;
    string? text;
    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();

        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено некорректное число");
    }
    return number;
}

bool IndeksCheck(int rowN, int colN, int[,] matr)  // BOOL функиця возвращает значение true - если она сработала, в другом случае возвращает false 
{

    if (rowN <= matr.GetLength(0) && colN <= matr.GetLength(1))
    { return true; }

    return false;
}




// int rows = InputNumber("Введите количество строк в массиве: ");
// int columns = InputNumber("Введите количество  столбца в массиве: ");
// System.Console.WriteLine();
// int[,] matrix = FillMatrix(rows, columns);
// PrintMatrix(matrix);
// System.Console.WriteLine();
// int rowNum = InputNumber("Введите на какой строке находится элемент в массиве: ");
// int colNum = InputNumber("Введите на каком столбце находится элемент в массиве: ");
// if (IndeksCheck(rowNum, colNum, matrix))
// {
//     System.Console.WriteLine($"Знаечение элемента, находящегося на {rowNum} строке, в {colNum} столбце: {matrix[rowNum - 1, colNum - 1]}");
// }
// else
// {
//     System.Console.WriteLine("Такого элемента не существует ");
// }





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int rows = InputNumber("Введите количество строк в массиве: ");
int columns = InputNumber("Введите количество  столбца в массиве: ");
System.Console.WriteLine();
int[,] matrix = FillMatrix(rows, columns);
PrintMatrix(matrix);
System.Console.WriteLine();

double sum = 0;
double average = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }

    average = sum / matrix.GetLength(0);
    sum = 0;
    System.Console.WriteLine(Math.Round(average, 2));
}

