// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

void PrintNaturalNumber(int m, int n) 
{ 
    if (m == n) Console.Write($"{n} "); 
    else 
    { 
        Console.Write($"{m}, "); 
        PrintNaturalNumber(m + 1, n); 
    } 
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

//Console.Clear();
int m = IntParseInput("Введите число M: ");
int n = IntParseInput("Введите число N: ");
PrintNaturalNumber(m, n);
Console.WriteLine();
