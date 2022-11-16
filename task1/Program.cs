// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

void Main()
{
    Console.Clear();
    int newNumber = 1;
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    WriteEvenNumber(number, newNumber);
}
// void WriteEvenNumber(int number, int newNumber)
// {
//     if (number > newNumber && number % 2 == 0)
//     
//         Console.Write($"{number} | ");
//     WriteEvenNumber(number - 1, newNumber);
// }
// Main();

void WriteEvenNumber(int number, int newNumber)
{
    if (number > newNumber)
    {
        if (number % 2 == 0)
            Console.Write($"{number} | ");
        WriteEvenNumber(number - 1, newNumber);
    }
}
Main();

