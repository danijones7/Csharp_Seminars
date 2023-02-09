﻿// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// rows = 3, cols = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


int[,] ArrayFill(int rows, int cols)
{
int[,] matrix = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
for (int j = 0; j < cols; j++)
{
matrix[i, j] = i + j;
}
}

return matrix;
}

void ShowArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write(matrix[i,j] + "\t");
}
Console.WriteLine();
}
}

int m = 3;
int n = 4;
int[,] array2d = ArrayFill(m,n);
ShowArray(array2d);