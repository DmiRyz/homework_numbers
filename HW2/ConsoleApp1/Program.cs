Console.WriteLine("Hello!");
Console.WriteLine("You can write a task number or \"0\" to exit");
bool timeToExit = false;
while (!timeToExit)
{
    Console.Write("Please, write task number: ");
    int taskNumber = Convert.ToInt32(Console.ReadLine());

    switch (taskNumber)
    {
        case 10:
            task10();
            break;
        case 13:
            task13();
            break;
        case 15:
            task15();
            break;
        case 16:
            task16();
            break;
        case 17:
            task17();
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

    void task10()
    {
        choseTask(10);
        Console.WriteLine("This task takes a three-digit number as input and displays the second digit of this number as output");
        Console.Write("Please, write three-digit number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        while(100 > number || number > 999)
        {
            Console.Write("Please, write three-digit number: ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Second digit is: " + (number / 10) % 10);
        taskCompleted(10);
    }
    
    void task13()
    {
        choseTask(13);
        Console.WriteLine("This task outputs the third digit of the given number, or reports that there is no third digit.");
        Console.Write("Please, write your number: ");
        string? number = Console.ReadLine();
        if(number.Length > 2)
        {
            Console.WriteLine("Third digit is: " + number[2]);
        }
        else
        {
            Console.WriteLine("No third digit");
        }
        taskCompleted(13);
    }
    
    void task15()
    {
        choseTask(15);
        Console.WriteLine("This task takes as input a digit indicating the day of the week and checks if this day is a weekend.");
        Console.Write("Please, write your number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        while(number < 1 || number > 7)
        {
            Console.Write("Please, write correct number: ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        if(number > 5)
        {
            Console.WriteLine("Oh yea! It is weekend, you can rest");
        }
        else
        {
            Console.WriteLine("You must work!");
        }
        taskCompleted(15);
    }
    
    void task16()
    {
        choseTask(16);
        Console.WriteLine("This task: \"Bank interest\"");
        Console.Write("Please, write starting amount: ");
        int startAmount = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please, write bank interest rate: ");
        int bankInterest = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please, write final amount: ");
        int finalAmount = Convert.ToInt32(Console.ReadLine());

        int numberOfYear = 0;
        int curretntSum = startAmount;

        while(curretntSum < finalAmount)
        {
            curretntSum += (curretntSum * bankInterest / 100);
            numberOfYear++;
        }

        Console.WriteLine(numberOfYear + " year");

        taskCompleted(16);
    }

    void task17()
    {
        choseTask(17);
        const int percent = 15;
        Console.WriteLine("This task: \"Morning running\"");
        Console.Write("Please, write distance at first day: ");
        int firstDistance = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please, write final distance: ");
        int finalDistance = Convert.ToInt32(Console.ReadLine());
        double currentDistance = firstDistance;
        int dayNumber = 1;
        while(currentDistance < finalDistance)
        {
            currentDistance += (currentDistance * percent / 100);
            dayNumber++;
        }

        Console.WriteLine(dayNumber + " days");

        taskCompleted(17);
    }

    void choseTask(int taskNumber)
    {
        Console.WriteLine("Ok, you chose task " + taskNumber + ". Let's go!");
    }

    void taskCompleted(int taskNumber)
    {
        Console.WriteLine("Task " + taskNumber + " completed successfully");
    }
}

