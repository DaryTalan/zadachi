Console.Write("Введите N для конечного значения: ");
int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            Console.Write(" {1}", i, Math.Pow(i,3));
        System.Console.WriteLine();