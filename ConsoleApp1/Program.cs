Console.Clear();
bool exit = false;
while (!exit)
{
    Console.WriteLine("You can write zero to exit");
    Console.Write("Write task number: ");
    int taskNumber = Convert.ToInt32(Console.ReadLine());

    switch (taskNumber)
    {
        case 2:
            task2();
            break;
        case 4:
            task4();
            break;
        case 6:
            task6();
            break;
        case 8:
            task8();
            break;
        case 0:
            exit = true;
            Console.WriteLine("Thank you. Goodbyуe!");
            break;
        default:
            Console.WriteLine("Sorry, task is not found :(");
            break;
    }

}

void task2()
{
    Console.Write("Please, enter first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please, enter second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    if (firstNumber > secondNumber)
    {
        Console.WriteLine("max = " + firstNumber);
        Console.WriteLine("min = " + secondNumber);
    }
    else if (firstNumber < secondNumber)
    {
        Console.WriteLine("max = " + secondNumber); 
        Console.WriteLine("min = " + firstNumber);
    }
    else
    {
        Console.WriteLine("the numbers are equal");
    }
}

void task4()
{
    Console.Write("Please, enter first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please, enter second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please, enter third number: ");
    int thirdNumber = Convert.ToInt32(Console.ReadLine());

    int max = firstNumber;
    if(secondNumber > max)
    {
        max = secondNumber;
    }
    if(thirdNumber > max)
    {
        max = thirdNumber;
    }

    Console.WriteLine("max number is: " + max);
}

void task6()
{
    Console.Write("Please, enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number % 2 == 0)
    {
        Console.WriteLine("Number is even");
        return;
    }
    Console.WriteLine("Number is odd");
}

void task8()
{
    Console.Write("Please, enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    for(int i = 2; i <= number; i = i + 2)
    {
        if (i + 2 > number)
        {
            Console.Write(i);
        }
        else
        {
            Console.Write(i + ", ");
        }
    }
}