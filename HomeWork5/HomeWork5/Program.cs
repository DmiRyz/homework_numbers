
bool timeToExit = false;

Console.WriteLine("Hello, you see homework 5!");
Console.WriteLine("You can write task number or \"0\" to exit");
Console.WriteLine("Ok, let`s go :) ");

while (!timeToExit)
{
    Console.Write("Please, write task number: ");

    int taskNumber = Convert.ToInt32(Console.ReadLine());

    switch (taskNumber)
    {
        case 34:
            task34();
            break;
        case 36:
            task36();
            break;
        case 38:
            task38();
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

void task34()
{
    choseTask(34);

    Console.WriteLine("This task generate random array and show the number of even numbers in the array: ");
    Console.Write("Please write array length: ");
    int arrayLength = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[arrayLength];
    int evenNumbers = 0;
    
    for(int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    showArrayInConsole(array);

    for (int j = 0; j < arrayLength; j++)
    {
        if (array[j] % 2 == 0)
        {
            evenNumbers++;
        }
    }

    Console.WriteLine("This array has " + evenNumbers + " even numbers");

    taskCompleted(34);
}

void task36()
{
    choseTask(36);

    Console.WriteLine("This task generate random array and show sum of elements in odd positions: ");
    Console.Write("Please write array length: ");
    int arrayLength = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[arrayLength];
    int sum = 0;

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
    }

    showArrayInConsole(array);

    for(int j = 1; j < array.Length; j += 2)
    {
        sum += array[j];
    }

    Console.WriteLine("sum of elements in odd positions: " + sum);

    taskCompleted(36);
}

void task38()
{
    choseTask(38);

    Console.WriteLine("This task generate random array and show the difference between the maximum and minimum array elements: ");
    Console.Write("Please write array length: ");
    int arrayLength = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[arrayLength];
    double maxNumber;
    double minNumber;

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().NextDouble() + new Random().Next(-1000, 1001);
    }

    Console.WriteLine("[" + string.Join("; ", array) + "]");

    if (array[0] > array[1])
    {
        maxNumber = array[0];
        minNumber = array[1];
    }
    else
    {
        maxNumber = array[1];
        minNumber = array[0];
    }

    for (int j = 2; j < array.Length; j++)
    {
        if (array[j] > maxNumber)
        {
            maxNumber = array[j];
        }
        else if (array[j] < minNumber)
        {
            minNumber = array[j];
        }

    }

    Console.WriteLine("Difference between the maximum and minimum array elements: " + (maxNumber - minNumber));

    taskCompleted(38);
}

void choseTask(int taskNumber)
{
    Console.WriteLine("Ok, you chose task " + taskNumber + ". Let's go!");
}

void taskCompleted(int taskNumber)
{
    Console.WriteLine("Task " + taskNumber + " completed successfully");
}

void showArrayInConsole(int[] array)
{
    Console.WriteLine("[" + string.Join(",", array) + "]");
}