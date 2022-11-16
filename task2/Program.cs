// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Main()
{
Console.Clear();
Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine());
SumNumber(numberM, numberN, 0);
}

void SumNumber(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Сумма натуральных чисел{sum}");
        return;
    }
    sum = sum + (numberM++);
    SumNumber(numberM, numberN, sum);
}
Main();
