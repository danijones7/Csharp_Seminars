// Принимает на вход число N и выводит все целые числа от минус N до N 

System.Console.WriteLine("enter number");
int N = Convert.ToInt32(Console.ReadLine());
int M = N * -1;
while (M < N) // или (M != N) не равно 
{
    System.Console.WriteLine(M);
    M ++;
}
