// Перевернуть массив. КОД НЕ ПОЛНЫЙ! Только часть про реверс


void ReverseArray(int[] arr)
{
int temp;
for (int i = 0; i < arr.Length / 2; i++)
{
temp = arr[i];
arr[i] = arr[arr.Length-i-1];
arr[arr.Length-i-1] = temp;
}
}


