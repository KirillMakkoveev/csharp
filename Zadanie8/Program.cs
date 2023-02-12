Console.WriteLine("vvedite chislo:");
int Number = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i< Number; i++)
{
if (i%2 == 0) Console.Write(i); else Console.Write(",");
}
