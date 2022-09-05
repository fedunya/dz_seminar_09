// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermanFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
            return AckermanFunction(n - 1, 1);
        else
            return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
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
int m = Math.Abs(IntParseInput("Введите число N: "));
int n = Math.Abs(IntParseInput("Введите число M: "));
Console.WriteLine("Функция Аккермана для чисел N и M равна: " + AckermanFunction(n, m));
