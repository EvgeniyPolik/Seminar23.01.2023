int Power(int number, int degree)
{
    if (degree == 0)
        return 1;
    return number * Power(number, degree - 1);
}

Console.Write("Введите основание степени: ");
var n = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите показатель степени: ");
var x = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Число {0} в степени {1}, равняется {2}", n, x, Power(n, x));