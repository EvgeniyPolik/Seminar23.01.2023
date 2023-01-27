List<int> MakeIntRandomList(int lenght, int minValue = 100, int maxValue = 1000)
{
    List<int> result = new List<int>();
    var rnd = new Random();
    for (int i = 0; i < lenght; i++)
        result.Add(rnd.Next(minValue, maxValue));
return result;
}

List<int> ReplaceTwenty(List<int> expList)
{
    var lenghtList = expList.Count();
    for (int i = 0; i < lenghtList; i++)
        if (expList[i] == 20)
        {
            expList[i] = 200;
            break;
        }
    return expList;
}

void PrintList(List<int> expList, string sep = " ")
{
    Console.Write("Сформированый массив: ");
    foreach (var element in expList)
    {
        Console.Write(element);
        Console.Write(sep);
    }
    Console.WriteLine();
}

Console.Write("Введите длину списка: ");
var lengthList = int.Parse(Console.ReadLine() ?? "0");
var expList = MakeIntRandomList(lengthList, 0, 100);
Console.WriteLine("Исходный список: ");
PrintList(expList);
ReplaceTwenty(expList);
Console.WriteLine("Измененный список: ");
PrintList(expList);


