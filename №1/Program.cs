int number (string N)
{
    int number;
    Console.Write($"Введите число {N}: ");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write($"Введите ЧИСЛО {N}: ");
    }
    return number;
}

int A = number("A");
int B = number("B");
System.Console.WriteLine($"Число {A} в степени {B} равно {degree (A, B)}");


int degree (int X, int Y)
{
    int Z = 1;
    for (int i = 1; i <= Y; i++)
    {
        Z = Z * X;
    }
    return Z;
}