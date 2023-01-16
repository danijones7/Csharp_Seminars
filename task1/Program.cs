// dotnet - пролверка все ли установлено 
// dotnet new console - создание проекта
// dotnet run - запуск проекта

Console.Write("enter integer number: "); // Вываод в консоль сообщения 
int number = Convert.ToInt32(Console.ReadLine()); // int.Parse  Convert.ToInt32() помогает в строку записать число, а не текст, предпочтительнее исп-ть Convert
int sqr = number * number;
System.Console.WriteLine($"Square number:  {sqr}"); //значок $ запускает форматирование, мы в тексте в фигурных скобках можем вставить переменную, иначе будет 
//System.Console.WriteLine("some text:" + sqr + "some more text");