// Задает рагдомное вещественное число, округляя его до нужного количества знаков после запятой 

Random rand = new Random();
double temp = Math.Round(rand.Next(-10, 10) + rand.NextDouble(), 3);
System.Console.WriteLine(temp);
