Console.WriteLine("vvedite chislo:");
int Number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i<=Number)
{
    int Result = i*i*i;
    Console.Write(Result + " ");
    i = i+1;
}