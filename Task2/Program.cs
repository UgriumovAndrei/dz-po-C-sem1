// Выдает максимальное из 3 чисел
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());
int m = n1;
if(n2 > m)
{
    m = n2;
}
if(n3 > m)
{
    m = n3;
}
Console.Write("max=" + m);