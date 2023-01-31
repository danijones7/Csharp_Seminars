// Выводит 3 цифру трехначного числа 

System.Console.WriteLine("enter 3-digit number");
int N = Convert.ToInt32(Console.ReadLine());
if(99 < N && N < 1000) // && and когда 2е условие собл и то и другое  || or или так или так 
{
    System.Console.WriteLine(N % 10);
}
else System.Console.WriteLine("incorrect number");