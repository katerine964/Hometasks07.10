// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int i=1;
while (i<=n)
{
    int m=i*i*i;
    i++;
    Console.WriteLine(m);
}