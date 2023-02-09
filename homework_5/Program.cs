

// // ВНИМАНИЕ СОДЕРЖИТСЯ 3 РАЗНЫЕ ЗАДАЧИ! КОД НЕ БУДЕТ РАБОТАТЬ, ЕСЛИ НЕ ЗАКОММЕНТИРОВАТЬ ОТДЕЛЬНЫЕ ЧАСТИ 


// int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange) // Заполняет массив нужным  количесвтом элементов size, от левой границы до правой) 
// {
//     int[] arr = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(leftRange, rightRange + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)  // Выводит на печать заданный или полученный массив 
// {
//     System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// }



// // Задача 1 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2

// int CountPositiveElements(int[] arr)
// {
//     int CountPositiveElements = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             CountPositiveElements = CountPositiveElements + 1;
//         }
//     }
//     return CountPositiveElements;
// }

// int[] array = FillArrayWithRandomNumbers(10, 100, 999);
// PrintArray(array);
// int count = CountPositiveElements(array);
// System.Console.WriteLine($"количество чётных чисел в массиве: {count}");


// // // Задача 2 Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// // // [3, 7, 23, 12] -> 19

// // // [-4, -6, 89, 6] -> 0

// int SumOfOddNumbers(int[] array)
// {
//     int SumOddNumners = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             SumOddNumners = SumOddNumners + array[i];
//         }
//     }
//     return SumOddNumners;
// }

// int[] array = FillArrayWithRandomNumbers(5, -10, 10);  // ругается потому что у него уже есть заданный такой массив выше 
// PrintArray(array);
// int sum = SumOfOddNumbers(array);
// System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна: {sum}");

// // //Задача 3 Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// // [3 7 22 2 78] -> 76

// double[] FillArrayWithRandomDoubleNumbers(int size, int leftRange, int rightRange) // Заполняет массив нужным  количесвтом элементов size, от левой границы до правой рандомными  вещественными числами
// {
//     double[] arr = new double[size];
//     Random rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 2);
//     }
//     return arr;
// }

// void PrintArrayDouble(double[] arr)  // Выводит на печать заданный или полученный массив из вещественных чисел 
// {
//     System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// }

// double FindMax(double[] array)
// {
//     double Max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > Max)
//         {
//             Max = array[i];
//         }
//     }
//     return Max;
// }

// double FindMin(double[] array)
// {
//     double Min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < Min)
//         {
//             Min = array[i];
//         }
//     }
//     return Min;
// }


// double[] array = FillArrayWithRandomDoubleNumbers(5, -10, 10);
// PrintArrayDouble(array);
// double maximum = FindMax(array);
// System.Console.WriteLine(maximum);
// double minimum = FindMin(array);
// System.Console.WriteLine(minimum);
// double result = maximum - minimum;
// System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {result}");






