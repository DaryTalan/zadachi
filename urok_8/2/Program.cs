void FillArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().Next(1, 15);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m, n]} ");
        }
        Console.WriteLine();
    }
}

int Sum(int[,] matr)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            if (m == 0) 
            {
                sum += matr[m, n];
                minSum += matr[m, n]; 
            }
            else sum += matr[m, n]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = m;
        }
        sum = 0;
    }
    return minNum;
}
int[,] mat = new int[3, 4] ;
FillArray(mat);
PrintArray(mat);
Console.WriteLine();
Console.WriteLine("Cтрока с наименьшей суммой элементов: " + Sum(mat));