int[] MakeIntRandomArray(int lenght, int minValue = 100, int maxValue = 1000)
{
    int[] result = new int[lenght];
    var rnd = new Random();
    for (int i = 0; i < lenght; i++)
        result[i] = rnd.Next(minValue, maxValue);
return result;
}

int GetSumNotEventIndex(int[] expArray)
{
    var result = 0;
    var lengthArray = expArray.Length;
    for (int i = 0; i < lengthArray; i++)
        if (i%2 != 0)
            result +=expArray[i];
    return result;
}

void PrintArray(int[] expArray, string sep = " ")
{
    Console.Write("Сформированый массив: ");
    foreach (var element in expArray)
    {
        Console.Write(element);
        Console.Write(sep);
    }
    Console.WriteLine();
}

Console.Write("Введите длину массива: ");
var lengthArray = int.Parse(Console.ReadLine() ?? "0");
var expArray = MakeIntRandomArray(lengthArray, -100, 100);
PrintArray(expArray);
Console.WriteLine("Сумма чисел с нечетными индексами: {0}", GetSumNotEventIndex(expArray));