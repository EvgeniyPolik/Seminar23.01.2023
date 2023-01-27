int[] MakeIntThreeDiditArray(int lenght)
{
    int[] result = new int[lenght];
    var rnd = new Random();
    for (int i = 0; i < lenght; i++)
        result[i] = rnd.Next(100, 1000);
return result;
}

int GetCountEventDigit(int[] expArray)
{
    var result = 0;
    foreach (var element in expArray)
        if (element % 2 == 0)
            result++;
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
var expArray = MakeIntThreeDiditArray(lengthArray);
PrintArray(expArray);
Console.WriteLine("Количество четных чисел в массиве: {0}", GetCountEventDigit(expArray));