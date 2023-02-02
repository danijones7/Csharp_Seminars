// // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

void PrintArray(int[] arr)  // Выводит на печать заданный или полученный массив 
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int InputNumber(string str)  // считывает введенный текст от пользователя, возвращает число, если текст - просит ввести еще раз 
{
    int number;
    string? text;
    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();

        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено некорректное число");
    }
    return number;
}

bool NumbCheck(int findnumber, int[] array)  // BOOL функиця возвращает значение true - если она сработала, в другом случае возвращает false 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == findnumber)
        {return true;}            

    }
    return false;
}



int[] array = { 6, 7, 19, 345, 3 };
PrintArray(array);
int num = InputNumber("Enter number");
if (NumbCheck(num, array))                  // не надо прописывать = true, функция если сработала и так возвращает это значение 
{
    System.Console.WriteLine("Yes");        // то есть "Если NumbCheck сработала, то ДА
}
else
{
    System.Console.WriteLine("No");         // если не сработало, то выводим НЕТ 
}





// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] == find)
//     {
//         System.Console.WriteLine("Yes");
//         break;
//     }
//     else
//     {
//         System.Console.WriteLine("No");
//     }


// }
