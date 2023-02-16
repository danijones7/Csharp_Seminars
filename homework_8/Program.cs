// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int[,] FillMatrix(int rows, int cols)
// {
//     int[,] matr = new int[rows, cols];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matr[i, j] = rand.Next(1, 10);
//         }
//     }
//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             System.Console.Write(matr[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// // int [,] StringsArrangedMatrix (int [,] matrix)
// // {
// // for (int i = 0; i < matrix.GetLength(0); i++)
// // {
// //     for (int j = 0; j < matrix.GetLength(1); j++)
// //     {
// //         for (int k = 0; k < matrix.GetLength(1) - 1; k++)
// //         {

// //             if (matrix[i, k] > matrix[i, k + 1])
// //             {
// //                 int temp = matrix[i, k + 1];
// //                 matrix[i, k + 1] = matrix[i, j];
// //                 matrix[i, k] = temp;
// //             }
// //         }
// //     }
// // }
// // return matrix;
// // }

// // int[,] matrix = FillMatrix(3, 4);
// // PrintMatrix(matrix);
// // System.Console.WriteLine();
// // int [,] arrangedMatrix = StringsArrangedMatrix (matrix);
// // PrintMatrix(matrix);


// // Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



// void PrintArray(int[] arr)  // Выводит на печать заданный или полученный массив 
// {
//     System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// }


// int[] ArrayStringsSums(int[,] matrix)
// {
//     int sum = 0;
//     int[] array = new int[matrix.GetLength(0)];
//     int k = 0;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];
//         }
//         array[k] = sum;
//         k++;
//         sum = 0;
//     }
//     return array;
// }


// int Minimum(int[] array)
// {
//     int min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {

//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }

//     return min;
// }




// // int[,] matrix = FillMatrix(3, 4);
// // PrintMatrix(matrix);
// // System.Console.WriteLine();
// // int[] array = ArrayStringsSums(matrix);
// // PrintArray(array);
// // int min = Minimum(array);
// // System.Console.WriteLine(min);
// // int StringNumber = Array.IndexOf(array, min)+1;
// // System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {StringNumber} строка");

// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// void MultiplyMatrix(int[,] matrixA, int[,] matrixB, int[,] resultMatrix)
// {
//     for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < matrixA.GetLength(1); k++)
//             {
//                 sum += matrixA[i, k] * matrixB[k, j];
//             }
//             resultMatrix[i, j] = sum;
//         }
//     }
// }

// int[,] matrixA = FillMatrix(2, 3);
// PrintMatrix(matrixA);
// System.Console.WriteLine();
// int[,] matrixB = FillMatrix(3, 3);
// PrintMatrix(matrixB);
// if (matrixA.GetLength(1) != matrixB.GetLength(0))
// {
// System.Console.WriteLine($"Произведение матриц не имеет смысла");
// }
// else
// {int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
// MultiplyMatrix(matrixA, matrixB, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// PrintMatrix (resultMatrix);
// }


// /* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// */

// int[,] FillMatrixtoSpiral(int row, int col)
// {
//     int[,] array = new int[row, col];

//     int Up = 0;    // Сужение сверху
//     int Down = 0;  // Сужение снизу
//     int Left = 0;  // Сужение слева
//     int Right = 0; // Сужение справа

//     // Переменные счетчики используемые в расчетах
//     int k = 1; // Счетчик, который присваивает значение элемнетам массива
//     int i = 0; // Координары строки
//     int j = 0; // Координаты столбца

//     while (k <= row * col)
//     {
//         array[i, j] = k;

//         // Проверка возможности движения вправо
//         if (i == Up && j < col - Right - 1)
//             ++j; // производится движение по столбцу вправо

//         // Проверка возможности движения вниз
//         else if (j == col - Right - 1 && i < row - Down - 1)
//             ++i; // производится движение по строкам вниз

//         // Проверка возможности движения влево
//         else if (i == row - Down - 1 && j > Left)
//             --j; // производится движение по столбцу влево

//         // Проверка возможности движения вверх
//         else
//             --i; // производится движение по строкам вверх

//         // Сужение диапазона, если окружность заполнена
//         if ((i == Up + 1) && (j == Left) && (Left != col - Right - 1))
//         {
//             ++Up;
//             ++Down;
//             ++Right;
//             ++Left;
//         }
//         ++k; // Счетчик увеличен на 1
//         // Цикл начинается заново
//     }
//     return array;
// }

// // Блок вывода элементов двумерного массива
// void PrintArray(int[,] array)
// {
//     for (int x = 0; x < array.GetLength(0); ++x)
//     {
//         for (int y = 0; y < array.GetLength(1); ++y)
//         {
//             System.Console.Write(array[x, y] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// // Основной блок программы
// int[,] SpiralArray = FillMatrixtoSpiral(4, 4);
// PrintArray(SpiralArray);


/* Задача 60. ...Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

// Метод для заполнения трехмерного массива
int[,,] FillMatrix3D(int length, int width, int height)
{
    int[,,] cube = new int[length, width, height];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < height; k++)
            {
                cube[i, j, k] = rand.Next(0, 10);
            }
        }
    }
    return cube;
}

// Метод для вывода элементов массива
void PrintMatrix3D(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                System.Console.Write(cube[i, j, k] + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

// Метод для построчного вывода элементов и индексов элементов трехмерного массива
void Print3DMatrixIndex(int[,,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write(matrix[i,j,k] + " (" + i + ", " + j + ", " + k + ")" + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

/******************************************************************************************************/
// Основной блок программы
System.Console.WriteLine("Программа для формирования трехмерного массива из случайных чисел от 0 до 9");
// Первый способ заполнения и вывода трехмерного массива
int[,,] Array3D = FillMatrix3D(2, 2, 2);
PrintMatrix3D(Array3D);

// РЕШЕНИЕ ПОСТАВЛЕННОЙ ЗАДАЧИ
// Dывод индексов элементов трехмерного массива
Print3DMatrixIndex(Array3D);