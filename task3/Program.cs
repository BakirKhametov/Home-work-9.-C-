// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Clear();
Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine());
FunctionOfAkkerman(numberM, numberN);

int FunctionOfAkkerman(int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;
    if (numberM > 0 && numberN == 0)
        return FunctionOfAkkerman(numberM - 1, 1);
    if (numberM > 0 && numberN > 0)
        return FunctionOfAkkerman(numberM - 1, FunctionOfAkkerman(numberM, numberN - 1));
    return FunctionOfAkkerman(numberM, numberN);
}
Console.WriteLine($"A({numberM},{numberN}) = {FunctionOfAkkerman(numberM, numberN)}");
