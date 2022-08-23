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
        case 54:
            task54();
            break;
        case 56:
            task56();
            break;
        case 58:
            task58();
            break;
        case 60:
            task60();
            break;
        case 61:
            task61();
            break;
        case 62:
            task62();
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

void task54()
{
    choseTask(54);

    Console.WriteLine("This task can sort in descending order the elements of each row of a two-dimensional array");

    Console.Write("Enter number of lines: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[line, columns];
    int[] array = new int[columns];

    Console.WriteLine("Old matrix: ");

    generateIntMatrix(matrix);

    Console.WriteLine("New matrix: ");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] = matrix[i, j];
        }

        int temp;

        for (int k = 0; k < array.Length; k++)
        {
            for (int l = 0; l < array.Length - 1 - k; l++)
            {
                if (array[l] > array[l + 1])
                {
                    temp = array[l];
                    array[l] = array[l + 1];
                    array[l + 1] = temp;
                }
            }
        }

        Console.WriteLine(string.Join("\t", array));
    }

    taskCompleted(54);
}

void task56()
{
    choseTask(56);

    Console.Write("Enter number of lines: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[line, columns];
    int[] array = new int[columns];
    generateIntMatrix(matrix);

    int minLine = 0;
    int minSum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] = matrix[i, j];
        }
        if (i == 0)
        {
            minSum = lineAmount(array);
            minLine = i;
        }
        else
        {
            if (lineAmount(array) < minSum)
            {
                minSum = lineAmount(array);
                minLine = i;
            }
        }
    }
    Console.WriteLine("Min sum: " + Convert.ToInt32(minLine + 1));

    taskCompleted(56);
}

void task58()
{
    choseTask(58);

    Console.Write("Enter number of lines: ");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] firstMatrix = new int[lines, columns];
    int[,] secondMatrix = new int[lines, columns];

    Console.WriteLine("First matrix: ");
    generateIntMatrix(firstMatrix);
    Console.WriteLine("Second matrix: ");
    generateIntMatrix(secondMatrix);

    int[,] resultMatrix = new int[lines, columns];

    Console.WriteLine("Result: ");

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
            Console.Write(resultMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

    taskCompleted(58);
}

void task60()
{
    choseTask(60);

    Console.Write("Enter lines: ");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter depth: ");
    int depth = Convert.ToInt32(Console.ReadLine());

    int[,,] array = new int[lines, columns, depth];

    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                Console.WriteLine(array[i, j, k] + " (" + i + "," + j + "," + k + ")");
            }
        }
    }

    taskCompleted(60);
}

void task61()
{
    choseTask(61);

    Console.Write("Enter number of line: ");
    int line = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[line, line * 2 - 1];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || j == i)
            {
                matrix[i, j] = 1;
            }
            else
            {
                matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
            }
        }
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != 0)
            {
                if (j == 0)
                {
                    for (int k = 0; k < matrix.GetLength(0) - 1 - i; k++)
                    {
                        Console.Write("   ");
                    }
                }
                Console.Write(matrix[i, j] + "     ");
            }
        }
        Console.WriteLine();
    }

    taskCompleted(61);
}

void task62()
{
    choseTask(62);

    int[,] matrix = new int[4, 4];
    int printCounter = 4;
    int counter = 1;
    int line = 0;
    int column = 0;
    int directionLine = 0;
    int directionColumn = 1;
    int turn = 0;
    int temp = 0;

    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[line, column] = counter++;
        printCounter--;
        if (printCounter == 0)
        {
            if (turn == 0 || turn == 1)
            {
                printCounter = 3;
            }

            if (turn == 2 || turn == 3)
            {
                printCounter = 2;
            }

            if (turn == 4 || turn == 5)
            {
                printCounter = 1;
            }

            temp = directionColumn;
            directionColumn = - directionLine;
            directionLine = temp;

            turn++;

        }
        line = line + directionLine;

        column = column + directionColumn;
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

    taskCompleted(62);
}

void generateIntMatrix(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

int lineAmount(int[] array)
{
    int amount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        amount = amount + array[i];
    }

    return amount;
}

void choseTask(int taskNumber)
{
    Console.WriteLine("Ok, you chose task " + taskNumber + ". Let's go!");
}

void taskCompleted(int taskNumber)
{
    Console.WriteLine("Task " + taskNumber + " completed successfully");
}