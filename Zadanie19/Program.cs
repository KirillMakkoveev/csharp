Console.WriteLine("VVedite 5* chislo ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number >= 10000 && Number <= 99999)
{
    int a = Number / 10000;
    int b = Number / 1000; b = b % 10;
    int c = Number / 10; c = c % 10;
    int d = Number % 10;
    if (a == d && b == c)
    Console.WriteLine("Yes"); else Console.WriteLine("No");
}
else Console.WriteLine("Error");