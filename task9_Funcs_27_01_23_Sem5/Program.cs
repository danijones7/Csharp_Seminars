// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// Функиц 1 

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange) // Заполняет массив нужным  количесвтом элементов size, от левой границы до правой) 
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

// Функция 2

void SumPositiveAndNegativeElements(int[] arr, out int sumP, out int sumN)  // В заданном массиве считает сумму всех положительных и сумму всех отрицательных чисел, НО НЕ ПЕЧАТАЕТ СРАЗУ РЕЗУЛЬТАТ 
{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumP += arr[i];
        }
        else
        {
            sumN += arr[i]; // sumNegative = sumNegative + array[i]
        }
    }
}

// Функция 3 

void PrintArray(int[] arr)  // Выводит на печать заданный или полученный массив 
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] array = FillArrayWithRandomNumbers(12, -9, 9);
PrintArray(array);
SumPositiveAndNegativeElements(array, out int sumP, out int sumN);

System.Console.WriteLine($"Сумма положительных = {sumP}, отрицательных = {sumN}");

