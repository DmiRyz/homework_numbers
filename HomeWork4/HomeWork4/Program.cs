
bool timeToExit = false;

Console.WriteLine("Hello, you see homework 4!");
Console.WriteLine("You can write task number or \"0\" to exit");
Console.WriteLine("Ok, let`s go :) ");

while (!timeToExit)
{
    Console.Write("Please, write task number: ");

    int taskNumber = Convert.ToInt32(Console.ReadLine());

    switch (taskNumber)
    {
        case 25:
            task25();
            break;
        case 27:
            task27();
            break;
        case 29:
            task29();
            break;
        case 30:
            task30();
            break;
        case 31:
            task31();
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

void task25()
{
    choseTask(25);

    Console.WriteLine("This task takes two numbers (A and B) as input and raises the number A to the natural power B");
    Console.Write("Please write A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please write B: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Result: " + Math.Pow(a, b));

    taskCompleted(25);
}

void task27()
{
    choseTask(27);

    Console.WriteLine("This task takes a number as input and returns the sum of the digits in the number");
    Console.Write("Please write your number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    while(number > 1)
    {
        sum += number % 10;
        number = number / 10;
    }

    Console.WriteLine(sum);

    taskCompleted(27);
}

void task29()
{
    choseTask(29);

    Console.WriteLine("This task defines an array of 8 elements and displays them on the screen");

    int[] array = new int[8];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Please write element number " + i + ": ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("[" + string.Join(",", array) + "]");

    taskCompleted(29);
}

void task30()
{
    choseTask(30);
    Console.WriteLine("Task name: \"Distance between peaks\"");
    int[] array = new int[100];
    int firstLocalMax = 0;
    int distance = 0;
    int minDistant = 0;

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Please write " + i + " element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());

        if (array[i] == 0)
        {
            break;
        }
    }
    
    for(int j = 1; j < array.Length - 1; j++)
    {
        if (array[j] == 0)
        {
            break;
        }

        if (array[j] > array[j - 1] && array[j] > array[j + 1])
        {
            if(firstLocalMax != 0)
            {
                distance = j - firstLocalMax;
                if (minDistant == 0 || distance < minDistant)
                {
                    minDistant = distance;
                }
            }
            
            firstLocalMax = j;
            j++;
            
        }
    }

    Console.WriteLine("Min distance: " + minDistant);

    taskCompleted(30);
}

void task31()
{
    choseTask(31);
    Console.WriteLine("Task: \"Picking blueberries\"");
    Console.Write("Please write quantity from 3 to 1000: ");
    int quantity = Convert.ToInt32(Console.ReadLine());
    int amount = 0;
    int tempAmount = 0;
    

    while(quantity < 3 || quantity > 1000)
    {
        Console.Write("Please write quantity from 3 to 1000: ");
        quantity = Convert.ToInt32(Console.ReadLine());
    }
    int[] array = new int[quantity];

    for(int i = 0; i < quantity; i++)
    {
        Console.Write("Please write " + i + " element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        //array[i] = new Random().Next(1, 1001);

    }

    for(int j = 0; j < array.Length; j++)
    {
        if(j == 0)
        {
            amount = array[array.Length - 1] + array[j] + array[j + 1];
            continue;
        }
        else if(j == array.Length - 1)
        {
            tempAmount = array[j - 1] + array[j] + array[0];
        }
        else
        {
            tempAmount = array[j - 1] + array[j] + array[j + 1];
        }

        if (tempAmount > amount)
        {
            amount = tempAmount;
        }
    }

    Console.WriteLine("Max amount is: " + amount);

    taskCompleted(31);
}

void choseTask(int taskNumber)
{
    Console.WriteLine("Ok, you chose task " + taskNumber + ". Let's go!");
}

void taskCompleted(int taskNumber)
{
    Console.WriteLine("Task " + taskNumber + " completed successfully");
}