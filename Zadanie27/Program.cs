// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumIntoNum (int num)
{
int sum = 0;
while (num > 0)
{
sum = sum + num%10; 
num = num / 10;
}
return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Результат суммы цифр внутри числа = {SumIntoNum(num)}");