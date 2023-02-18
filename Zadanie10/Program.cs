Console.WriteLine("vvedite trechznachnoe chislo:");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number <= 999 && Number >= 100)
{
Number = Number / 10;
Number = Number % 10;
Console.WriteLine(Number);
}
else Console.WriteLine("Error");