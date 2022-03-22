Console. Write ("Введите через пробел координаты первой точки x: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console. Write ("Введите через пробел координаты первой точки y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console. Write ("Введите через пробел координаты первой точки z: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console. Write ("Введите через пробел координаты второй точки x: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console. Write ("Введите через пробел координаты второй точки y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console. Write ("Введите через пробел координаты второй точки z: ");
double z2 = Convert.ToDouble(Console.ReadLine());

    double d = Math.Pow((Math.Pow(x2 - x1, 2) +  Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) *  1.0), 0.5);

Console.WriteLine("Distance is \n" + d);
return;