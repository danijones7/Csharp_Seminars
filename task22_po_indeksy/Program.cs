// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

void ConvertArrayByIndeks(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i > 0 && i % 2 != 0 && j > 0 && j % 2 != 0)
            {
                matr[i, j] = (int)Math.Pow(matr[i, j], 2);   // error CS0266: Не удается неявно преобразовать тип "double" в "int". 
                                                             // Существует явное преобразование (возможно, пропущено приведение типов).
            }                                               // если не поставить (int) перед функцией 
        }
    }
    return;
}




int[,] matrix = FillMatrix(3, 4);
PrintMatrix(matrix);
System.Console.WriteLine();
ConvertArrayByIndeks(matrix);
PrintMatrix(matrix);




/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4*/

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

int MatrixEdit(int[,] matrix)
{
int result = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if ((i == j))                   // очень изящное решение для нахождения главной диагонали 
{
result += matrix[i, j];
}
}
}
return result;
}


System.Console.WriteLine("Введите rows и cols: ");
int rows = Convert.ToInt32(Console.ReadLine());
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[,] array2d = FillMatrix(rows, cols);
PrintMatrix(array2d);
System.Console.WriteLine();
System.Console.WriteLine(MatrixEdit(array2d));