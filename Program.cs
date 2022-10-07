// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n.ToString()[4]==n.ToString()[0] && n.ToString()[1]==n.ToString()[3])
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
