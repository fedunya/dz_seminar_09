// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNaturalNumbers(int m, int n)
{
    int result = 0;
    if (m == n) return result = result + n;
    else return result = m + SumNaturalNumbers(m + 1, n);
}
int IntParseInput(string str)
{
ReadInput:
    Console.Write(str);
    var inputStringA = Console.ReadLine()!;
    if (!int.TryParse(inputStringA, out int num))
    {
        Console.WriteLine("Введено не число!");
        goto ReadInput;
    }
    else return num;
}

Console.Clear();
int m = IntParseInput("Введите число M: ");
int n = IntParseInput("Введите число N: ");
Console.WriteLine("Сумма чисел от M до N равна: " + SumNaturalNumbers(m, n));
