// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.


int[,] FillMatrix(int rows, int cols)
{
int[,] matr = new int[rows, cols];
Random rand = new Random();
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < cols; j++)
{
matr[i, j] = rand.Next(1, 10);
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

int[,] ReverseMatrix(int[,] matrix)
{
int[,] matrix2 = new int[matrix.GetLength(1), matrix.GetLength(0)];
for (int i = 0; i < matrix2.GetLength(0); i++)
{
for (int j = 0; j < matrix2.GetLength(1); j++)
{
matrix2[i, j] = matrix[j, i];
}
}
return matrix2;
}

int[,] matrix = FillMatrix(3, 5);
PrintMatrix(matrix);
System.Console.WriteLine();

PrintMatrix (ReverseMatrix(matrix));
