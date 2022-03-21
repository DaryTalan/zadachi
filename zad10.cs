Console.Write("Chislo: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x<100) 
Console.WriteLine("число меньше необходимого");
else 
if (x>1000) 
Console.WriteLine("число больше необходимого");
else 
System.Console.WriteLine($"Второй цифрой числа {x} является {x / 10 % 10} ");
System.Console.WriteLine(); 
