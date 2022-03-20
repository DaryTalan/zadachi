Console.Write("Chislo vvedite 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Chislo vvedite 2: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > y)
{
Console.WriteLine("{0} Maximal: ", y);
}
else
{
Console.WriteLine("{0} Maximal: ", x);
}