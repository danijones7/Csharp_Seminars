// Проверить кратно ли 1е число 2му и если не кратно выести остаток от деления 

System.Console.WriteLine("enter 1st number:");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("enter 2nd number:");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num1 % num2;
if (result == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine($"Не кратно. Остаток: {result}");
}

// Еще одна задача такого же типа. Проверить кратно ли число одновременно и 7 и 23 (161 кратно)

// if (num1 % 7 == 0 && num1 % 23 == 0) // вместо and применяют && вместо or применяют || 
// {
//     System.Console.WriteLine("Yes");
// }
// else{
//     System.Console.WriteLine("No");
// }

// Чтобы закооментировать строку выделить нажать ctrl K и ctrl с 
// чтобы расскомментировать выделить нажать ctrl k & ctrl U  
// или просто выделать и CTRL /  - это комментирует и раскомментирует
