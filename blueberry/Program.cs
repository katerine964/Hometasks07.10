// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число ягод на каждом кусте, соответственно");
int[] array = new int[n];
for (int i=0; i<n; i++)
{
    array[i] = new Random().Next(1,1000);
    Console.Write(array[i]+" ");
}
int[] massive = new int[n];
massive[0]=array[n-1]+array[0]+array[1];
massive[n-1]=array[n-1]+array[0]+array[n-2];
for (int i=1; i<n-1; i++)
{
    massive[i]=array[i-1]+array[i]+array[i+1];
}
Console.WriteLine(" ");
int max = massive.Max();

/*Если не использовать существующий метод Мах(), то написали бы так:

int max = massive[0];
for (int i=1; i<n; i++)
{
    if(massive[i]>max)
    {
        max=massive[i];
    }
}
Console.WriteLine("максимальное число ягод за один заход-" + max);

Еще один способ без создания второго массива:

int max=array[0]+array[1]+array[n-1];
if ((array[0]+array[n-2]+array[n-1])>max)
{
    max=array[0]+array[n-2]+array[n-1];
}
for (int i=1; i<n-1; i++)
{
    if((array[i]+array[i-1]+array[i+1])>=max)
    {
        max=array[i]+array[i-1]+array[i+1];
    }
}*/
Console.WriteLine("Максимальное число ягод за один заход: " + max);
