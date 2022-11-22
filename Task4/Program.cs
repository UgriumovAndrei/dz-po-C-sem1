// ввод n, вывод все четные число от (1 до n]
int n = Convert.ToInt32(Console.ReadLine());
int p = 2;
while(p<=n)
    {
        Console.Write(p + " ");
        p+=2;
    }