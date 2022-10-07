// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите абсциссу первого числа:");
double x1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ординату первого числа:");
double y1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите аппликату первого числа:");
double z1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите абсциссу второго числа:");
double x2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ординату второго числа:");
double y2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите аппликату первого числа:");
double z2=Convert.ToDouble(Console.ReadLine());
double m1 = x2-x1;
double m2=y2-y1;
double m3=z2-z1;
double r = Math.Sqrt(m1*m1+m2*m2+m3*m3);
Console.WriteLine("расстояние " + r);
