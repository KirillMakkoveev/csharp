Console.WriteLine("vvedite chislo:");
int Number = Convert.ToInt32(Console.ReadLine());
if ( Number <= 99) Console.WriteLine("tretiei cifri net");
else
{
    for (int i = 1; Number>=1000; i=i*10)
Number = Number / 10;
Number = Number % 10;
Console.WriteLine(Number);
}