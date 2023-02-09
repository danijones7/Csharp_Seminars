// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
int[] arr = new int[size];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rand.Next(leftRange, rightRange + 1);
}
return arr;
}

int[] array = FillArrayWithRandomNumbers(4, 0, 10);
System.Console.WriteLine("Изначальный массив: [" + string.Join(", ", array) + "]");

int[] otherArray = new int[4];

for (int i = 0; i < array.Length; i++)
{
otherArray[i] = array[i];
}

System.Console.WriteLine("Скопированный массив: [" + string.Join(", ", otherArray) + "]");


// С использованием функции:

// Задача 45: Напишите программу, которая будет создавать копию заданного
// массива с помощью поэлементного копирования.

int[] RandomArrayCreation(int size, int leftValue, int rightValue)
{
int[] arr = new int[size];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rand.Next(leftValue, rightValue + 1);
}
return arr;
}

int[] ArrayCopying(int[] array)
{
int[] arrayCopy = new int[array.Length];
for (int i = 0; i < arrayCopy.Length; i++)
{
arrayCopy[i] = array[i];
}
return arrayCopy;
}


int[] arr = RandomArrayCreation(5, 0, 10);
Console.WriteLine("[" + string.Join(",", arr) + "]");
int[] arr2 = ArrayCopying(arr);
Console.WriteLine("[" + string.Join(",", arr2) + "]");