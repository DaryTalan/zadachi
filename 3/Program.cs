Console.Write("Chislo vvedite 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Chislo vvedite 2: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Chislo vvedite 3: ");
int z = Convert.ToInt32(Console.ReadLine());
if (x > y && x > z)
{
    Console.WriteLine(" Maximal: {0}", x); 
}
else if (y > z)
{ 
    Console.WriteLine(" Maximal: {0}", y);
}
else 
    Console.WriteLine(" Maximal: {0}", z);
    
