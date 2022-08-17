bool timeToExit = false;

Console.WriteLine("Hello, you see homework 6!");
Console.WriteLine("You can write task number or \"0\" to exit");
Console.WriteLine("Ok, let`s go :) ");

while (!timeToExit)
{
    Console.Write("Please, write task number: ");

    int taskNumber = Convert.ToInt32(Console.ReadLine());

    switch (taskNumber)
    {
        case 41:
            task41();
            break;
        case 43:
            task43();
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

void task41()
{
    choseTask(41);

    Console.WriteLine("This task can count how many numbers are greater than zero");
    Console.Write("How many numbers do you want to enter: ");
    int countAll = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[countAll];
    int countGreaterZero = 0;

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Please enter " + (i + 1) + " number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());

        if(array[i] > 0)
        {
            countGreaterZero++;
        }
    }

    Console.WriteLine(Convert.ToString(countGreaterZero) + " numbers are greater than zero");

    taskCompleted(41);
}

void task43()
{
    choseTask(43);

    Console.WriteLine("This task can finds the intersection point of two lines given by the equations y = k1 * x + b1, y = k2 * x + b2.");
    Console.Write("Enter b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine("Intersection point of two lines: (" + x + "; " + y + ")" );

    taskCompleted(43);
}

void choseTask(int taskNumber)
{
    Console.WriteLine("Ok, you chose task " + taskNumber + ". Let's go!");
}

void taskCompleted(int taskNumber)
{
    Console.WriteLine("Task " + taskNumber + " completed successfully");
}
