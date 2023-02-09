﻿// Дз по 6му семинару от 31,01,2023



// // // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3


// int[] UserFillsArray(string str)   
// {

//     System.Console.WriteLine(str);
//     int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//     return arr;
// }





// int CountPositiveNumbers(int[] arr)
// {
//     int count = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] array = UserFillsArray("Введите числа через пробел");
// int result = CountPositiveNumbers(array);
// System.Console.WriteLine($"Количество чисел больше 0: {result}");







// // Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)


double InputNumber(string str)  // считывает введенный текст от пользователя, возвращает  вещественное число, если текст - просит ввести еще раз 
{
    double number;
    string? text;
    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();

        if (double.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено некорректное число");
    }
    return number;
}

void CrossLinesPoint (double b1, double k1, double b2, double k2, out double x, out double y)
{

x = -(b1 - b2) / (k1 - k2);
y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

}

CrossLinesPoint(InputNumber("Введите b1: "), InputNumber("Введите k1: "), InputNumber("Введите b2: "), InputNumber("Введите k2: "), out double x, out double y);

Console.WriteLine($"Пересечение в точке: ({x};{y})");