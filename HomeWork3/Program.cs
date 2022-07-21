bool timeToExit = false;

Console.WriteLine("Hello, you see homework3!");
Console.WriteLine("You can write task number or \"0\" to exit");
Console.WriteLine("Ok, let`s go :) ");

while (!timeToExit)
{
    Console.Write("Please, write task number: ");

    int taskNumber = Convert.ToInt32(Console.ReadLine());

    switch (taskNumber)
    {
        case 19:
            task19();
            break;
        case 21:
            task21();
            break;
        case 23:
            task23();
            break;
        case 24:
            task24();
            break;
        case 0:
            timeToExit = true;
            Console.WriteLine("Thank you. See you again :)");
            break;
        default:
            Console.WriteLine("Sorry, task number " + taskNumber + " is not found :(");
            Console.WriteLine("Try again or write \"0\" to exit");
            break;
    }
}

void task19()
    {
    choseTask(19);
    Console.WriteLine("This task takes a five-digit number as input and checks if it is a palindrome");
    Console.Write("Please write five-digit numbers: ");
    string? number = Console.ReadLine();
    while(number.Length != 5)
    {
        Console.WriteLine("Sorry! Number must have only five digit. Please try again!");
        Console.Write("Write five-digit numbers: ");
        number = Console.ReadLine();
    }
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Ok! Number " + number + " is a palindrome");
    }
    else
    {
        Console.WriteLine("Ok! Number " + number + " not a palindrome");
    }

        taskCompleted(19);
    }

void task21()
{
    choseTask(21);
    Console.WriteLine("This task takes as input the coordinates of two points and finds the distance between them in 3D space");
    Console.Write("Write ax: ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.Write("Write ay: ");
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.Write("Write az: ");
    int az = Convert.ToInt32(Console.ReadLine());
    Console.Write("Write bx: ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.Write("Write by: ");
    int by = Convert.ToInt32(Console.ReadLine());
    Console.Write("Write bz: ");
    int bz = Convert.ToInt32(Console.ReadLine());
    
    double result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
    Console.WriteLine(Math.Round(result, 2));
    
    taskCompleted(21);
}

void task23()
{
    choseTask(23);
    Console.WriteLine("This task takes a number (N) as input and produces a table of cubes of numbers from 1 to N");
    Console.Write("Write N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    for(int i = 1; i <= n; i++)
    {
        if (i == n)
        {
            Console.WriteLine(Math.Pow(i, 3));
        }
        else
        {
            Console.Write(Math.Pow(i, 3) + ", ");
        }
    }
    
    taskCompleted(23);
}

void task24()
{
    choseTask(24);
    Console.Write("Write array length: ");
    int arrayLength = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[arrayLength];
    for(int i = 0; i < arrayLength; i++)
    {
        Console.Write("Write " + i + " array element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    int max = 0;
    int premax = 0;

    if (array[0] > array[1])
    {
        max = array[0];
        premax = array[1];
    }
    else
    {
        max = array[1];
        premax = array[0];
    }

    for(int j = 2; j < array.Length; j++)
    {
        if (array[j] == 0)
        {
            break;
        }

        if (array[j] > max)
        {
            max = array[j];
        }
        
    }

    for(int k = 0; k < array.Length; k++)
    {
        if (array[k] == 0)
        {
            break;
        }

        if (array[k] > premax && array[k] < max)
        {
            premax = array[k];
        }
    }

    Console.WriteLine("Second max number: " + premax);

    taskCompleted(24);
}

void choseTask(int taskNumber)
{
    Console.WriteLine("Ok, you chose task " + taskNumber + ". Let's go!");
}

void taskCompleted(int taskNumber)
{
    Console.WriteLine("Task " + taskNumber + " completed successfully");
}

