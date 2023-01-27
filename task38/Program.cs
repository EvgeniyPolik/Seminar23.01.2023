int[] MakeIntRandomArray(int lenght, int minValue = 100, int maxValue = 1000)
{
    int[] result = new int[lenght];
    var rnd = new Random();
    for (int i = 0; i < lenght; i++)
        result[i] = rnd.Next(minValue, maxValue);
return result;
}

Tuple<int, int, int> MaxMinDiff(int[] expArray)
{
    var maxElement = expArray[0];
    var minElement = expArray[0];
    foreach (int element in expArray)
    {
        if (element > maxElement)
            maxElement = element;
        if (element < minElement)
            minElement = element;
    }
    return new Tuple<int, int, int>(maxElement, minElement, maxElement - minElement);
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
var expArray = MakeIntRandomArray(lengthArray, 0, 100);
PrintArray(expArray);
var maxMinDiff = MaxMinDiff(expArray);
Console.WriteLine("Разница между максимальным({0}) и минимальным({1}) элементом массива: {2}", maxMinDiff.Item1, maxMinDiff.Item2, maxMinDiff.Item3);
