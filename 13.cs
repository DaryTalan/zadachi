Console.Write("Chislo: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Дано число: {x}");
if (x / 100 > 0) System.Console.WriteLine($"Третьей является цифра {x % 10}");
else System.Console.WriteLine($"У числа {x} нет третьей цифры");
System.Console.WriteLine();
