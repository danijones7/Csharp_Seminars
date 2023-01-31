// Напишите программу, которая выводит случайное число из отрезка [10; 99]
// и показывает наибольшую цифру числа 

Random rand = new Random(); // объявление объекта КЛАССА Random
int randnumber = rand.Next(10, 100); // генерация переменной от 1 до 99 || [10; 100) == [10; 99]

// int randnamber2 = new Random().Next(10,100); - ВТОРОЕ ТИП ЗАПИСИ,НЕ ПРИНЯТО ТАК ДЕЛАТЬ, ЕСЛИ ОБРАЩАЮТСЯ К КЛАССУ RANDOM БОЛЬШЕ ОДНОГО РАЗА 

System.Console.WriteLine(randnumber);

if (randnumber / 10 > randnumber % 10)
{
    System.Console.WriteLine($"Большая цифра числа{randnumber}: {randnumber / 10}");
}
else
{
    System.Console.WriteLine($"большая цифра числа {randnumber}: {randnumber % 10}");
}