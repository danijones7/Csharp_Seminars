// Генерерует 3х значное число, и удаляет втоhe. цифру этого числа 

Random rand = new Random();
int randnumber = rand.Next(100, 1000);
System.Console.WriteLine(randnumber);
//int seconddigit = randnumber % 10;
//int firstdigit = randnumber / 100;
//System.Console.WriteLine($"{firstdigit}{seconddigit}");

int newnumber = (randnumber / 100) * 10 + randnumber % 10; // если это число необходимо использовать в дальнейшем лучше вычислить его математически 
System.Console.WriteLine(newnumber);
