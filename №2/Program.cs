int number (string N)
{
    int number;
    System.Console.Write($"Введите число {N}: ");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write($"Введите число {N}: ");
    }
    return number;
}

int N = number ("N");
System.Console.WriteLine($"Сумма цифр числа {N} равна {sum(N)}");

int sum (int N)
{
   int remainder = 0;
   while (N>=10)
   {
    remainder = remainder + N%10;
    N = N/10;
   }
   return remainder+N;
}
