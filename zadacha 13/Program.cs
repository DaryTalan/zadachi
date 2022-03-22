Console.Write("Chislo: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Дано число: {x}");
if (x > 99999 && x < 999999) System.Console.WriteLine($"Третьей является цифра {x /1000 % 10}");
else if (x > 9999 && x < 99999) System.Console.WriteLine($"Третьей является цифра {x /100 % 10}");
else if (x > 999 && x < 9999) System.Console.WriteLine($"Третьей является цифра {x /10 % 10}");
else if (x > 99) System.Console.WriteLine($"Третьей является цифра {x % 10}");
else System.Console.WriteLine($"У числа {x} нет третьей цифры");
System.Console.WriteLine();