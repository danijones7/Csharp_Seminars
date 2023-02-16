/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
45 -> 101101 
3  -> 11 
2  -> 10*/ 
 
int Number(string str) 
{ 
    System.Console.WriteLine(str);  
    return Convert.ToInt32(Console.ReadLine()); 
} 
 
// int Res(int number) 
// {   int result = 0;
//     while (number != 0) 
//     { 
//         result += number % 2; 
//         number /= 2; 
//     } 
//     return number; 
// } 
 
string ReverseString(string str) 
{ 
    string res = string.Empty; 
    for (int i = 0; i < str.Length; i++) 
    { 
    res += str[^i]; 
    } 
    return res; 
} 
 
int number = Number("Введите число: "); 
System.Console.WriteLine(number); 
 
string result = string.Empty; 
string S = ReverseString(result); 
System.Console.WriteLine(S);
