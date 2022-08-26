bool timeToExit = false;

Console.WriteLine("Hello, you see homework 8!");
Console.WriteLine("You can write task number or \"0\" to exit");
Console.WriteLine("Ok, let`s go :) ");

while (!timeToExit)
{
    Console.Write("Please, write task number: ");

    int taskNumber = Convert.ToInt32(Console.ReadLine());

    switch (taskNumber)
    {
        case 66:
            task66();
            break;
        case 68:
            task68();
            break;
        /*case 69:
            task69();
            break;*/
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

void task66()
{
    choseTask(66);
    Console.WriteLine("This task can finds the sum of natural elements in the interval from M to N!");
    Console.Write("Please enter M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please enter N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Sum of natural elements in the interval from " + m + " to " + n + ": " + result(m, n));

    taskCompleted(66);
}

int result(int m, int n)
{
    if(m == n)
    {
        return m;
    }

    return result(m, n - 1) + n;
}

void task68()
{
    choseTask(68);
    Console.WriteLine("This task can calculating the Ackermann function");
    Console.Write("Please enter M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please enter N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("A(" + m + ", " + n + ") = " + fAckermann(m, n));

    taskCompleted(68);
}

int fAckermann(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(m > 0 && n == 0)
    {
        return fAckermann(m - 1, 1);
    }

    return fAckermann(m - 1, fAckermann(m, n - 1));
}

/*void task69()
{
    choseTask(69);
    bool error = false;
    int transpositionIndex = 0;
    Console.Write("Please enter a string whose length from 1 to 8: ");
    string? inputString = Console.ReadLine();
    if(inputString == null || inputString.Length < 1 || inputString.Length > 8)
    {
        Console.Write("Please enter a string whose length from 1 to 8: ");
        inputString = Console.ReadLine();
    }

    for(int i = 0; i < inputString.Length; i++)
    {
        string temp = Convert.ToString(inputString[i]);
        for(int j = 0; j < inputString.Length; j++)
        {
            if (temp.Equals(inputString[j]))
            {
                error = true;
            }
        }
    }

    if (!error)
    {
        transposition(inputString, transpositionIndex);
    }


    taskCompleted(69);
}

void transposition(string inputString, int transpositionIndex)
{
    string temp;
    if(transpositionIndex == inputString.Length - 1)
    {

    }
}*/

void choseTask(int taskNumber)
{
    Console.WriteLine("Ok, you chose task " + taskNumber + ". Let's go!");
}

void taskCompleted(int taskNumber)
{
    Console.WriteLine("Task " + taskNumber + " completed successfully");
}
