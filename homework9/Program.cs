// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Akerman(int m, int n)
// {
// if (m == 0)
// {
// return n+1;
// }
// if (m > 0 && n ==0)
// {
// return Akerman(m-1,1);
// }
// if (m > 0 && n > 0)
// {
// return Akerman(m-1, Akerman(m, n -1));
// }
// return 0;
// }

// int n = Akerman(3, 2);
// System.Console.WriteLine(n);



// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


// int StepenNum (int n, int m)
// {
// if (m > 1)
// return n*StepenNum(n,m-1);
// return n;
// }
// System.Console.WriteLine(StepenNum(2,3));



//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElements (int m, int n)
{    
   
    if (m <= n)
    {        
        return m + SumElements(m+1, n);
    }
    return 0;
}


// Основной блок программы

System.Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = SumElements(M, N);
System.Console.WriteLine("Сумма натуральных элементов в промежутке от от M до N: ");
System.Console.WriteLine(Sum);