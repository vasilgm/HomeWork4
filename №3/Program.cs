Main();

void Main()
{
	bool isWorking = true;

	while (isWorking)
	{
		Console.WriteLine(" ");
        Console.Write("Enter manually or randomly: ");

		string task = Console.ReadLine();

		switch (task)
		{
			case "manually": Task1(); break;
			case "randomly": Task2(); break;
            case  "exit": isWorking = false; break;
			default:
				break;
		}
	}
}

void Task1()
{
    System.Console.WriteLine(" ");
    
    int[] array = new int [8]; 
    
    for (int i = 0; i < 8; i++)
    {
        array [i] = number (i);
    }

    System.Console.WriteLine(" ");
    
    for (int i = 0; i < 8; i++)
    {
        System.Console.WriteLine($"element number {i+1} equals {array[i]}");
    }
}

void Task2()
{
    System.Console.WriteLine(" ");
   
    int[] array = new int [8];
    
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
    
    for (int i = 0; i < 8; i++)
    {
        System.Console.WriteLine($"element number {i+1} equals {array[i]}");
    }
}

int number (int i)
{
    int number;
    System.Console.Write($"enter item number {i+1}: ");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write($"enter item number {i+1}: ");
    }
    return number;
}