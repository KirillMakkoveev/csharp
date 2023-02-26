// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] array)
{
int length = array.Length;
for (int index = 0; index < length; index++)
{
array[index] = new Random().Next(0, 10);
}
}
void PrintArray(int[] mas)
{
int len = mas.Length;
for (int i = 0; i < len; i++)
{
Console.Write(mas[i] + " ");
}
}
int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);