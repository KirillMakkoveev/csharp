// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetSqtNums(int num1, int num2)
{
int sqt = 1;
while (num2 > 0)
{
sqt = sqt * num1;
num2--;

}
return sqt;
}

Console.Clear();
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());


Console.WriteLine($"Результат возведения А в степень Б = {GetSqtNums(A,B)}");

