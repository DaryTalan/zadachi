int[] array = new int[8];
  Random myRandom = new Random();
  Console.WriteLine("Случайный массив:");
for (int i = 0; i < array.Length; i++)
     {
      array[i] = myRandom.Next(0, 8);
    Console.Write("{0} ", array[i]);
     }