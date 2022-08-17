bool timeToExit = false;

Console.WriteLine("Hello, you see homework 7!");
Console.WriteLine("You can write task number or \"0\" to exit");
Console.WriteLine("Ok, let`s go :) ");

while (!timeToExit)
{
    Console.Write("Please, write task number: ");

    int taskNumber = Convert.ToInt32(Console.ReadLine());

    switch (taskNumber)
    {
        case 47:
            task47();
            break;
        case 50:
            task50();
            break;
        case 52:
            task52();
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

void task47()
{
    choseTask(47);
    Console.WriteLine("This task generate random matrix.");
    Console.Write("Enter number of lines: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] matrix = new double[line, columns];
    generateDoubleMatrix(matrix);

    taskCompleted(47);
}

void task50()
{
    choseTask(50);
    Console.WriteLine("This task can return element value from matrix.");

    Console.WriteLine("This task generate random matrix.");
    Console.Write("Enter number of lines: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter find lines: ");
    int findLines = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter find columns: ");
    int findColumns = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[line, columns];
    generateIntMatrix(matrix);

    if(findLines > line || findColumns > columns)
    {
        Console.WriteLine("404:(");
        Console.WriteLine("Element not found"); 
    }
    else
    {
        Console.WriteLine(matrix[findLines - 1, findColumns - 1]);
    }
}

void task52()
{
    choseTask(52);
    Console.WriteLine("This task can find arithmetic mean of the elements in each column.");

    Console.WriteLine("This task generate random matrix.");
    Console.Write("Enter number of lines: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[line, columns];
    generateIntMatrix(matrix);

    double result = 0;
    int counter = 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        result = 0;
        counter = 0;

        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            result += matrix[i, j];
            counter++;
        }

        Console.Write(Math.Round(result / counter, 2) + "\t");
    }

    taskCompleted(52);
}

void generateDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(-100, 101), 5);
        }
    }
}

void generateIntMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
        }
    }
}

void choseTask(int taskNumber)
{
    Console.WriteLine("Ok, you chose task " + taskNumber + ". Let's go!");
}

void taskCompleted(int taskNumber)
{
    Console.WriteLine("Task " + taskNumber + " completed successfully");
}
