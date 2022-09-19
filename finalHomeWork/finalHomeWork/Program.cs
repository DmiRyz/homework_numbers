Console.Write("Введите длину массива строк ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];
string[] arrayResult = new string[n];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Строка " + (i + 1) + ": ");
    array[i] = Console.ReadLine();
}

Console.WriteLine("Исходный массив строк: ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        arrayResult[count] = array[i];
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("Итоговый массив строк: ");

for (int i = 0; i < arrayResult.Length; i++)
{
    Console.Write($"{arrayResult[i]} ");
}