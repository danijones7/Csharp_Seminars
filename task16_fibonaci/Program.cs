// *Задача 44: Не используя рекурсию, выведите
// первые N чисел Фибоначчи. Первые два числа
// Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8*/

int Number(string str)
{
System.Console.WriteLine(str);
return Convert.ToInt32(Console.ReadLine());
}

int N = Number("Введите N: ");

int firstNum = 0;
int secondNum = 1;
System.Console.Write("0, 1");

for (int i = 0; i < N-2; i++)  // Здесь N - 2 ? потому что первые два числа записаны выше 0 и 1
{
int fibonacci = firstNum + secondNum;
System.Console.Write($", {fibonacci}");
firstNum = secondNum;
secondNum = fibonacci;
}
