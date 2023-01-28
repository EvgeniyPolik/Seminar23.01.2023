string[] MakeNewGame(int lenght)
{
    var result = new string[lenght];
    for (int i = 0; i < lenght; i++)
        result [i] = "I";
    return result;
}

string[] DoSrike(string[] bowlingAlley, int li, int ri)
{
    for (int i = li - 1; i <= ri - 1; i++)
        bowlingAlley[i] = ".";
    return bowlingAlley;
}

void PrintStatus(string[] bowlingAlley)
{
    Console.WriteLine("Результат броска:");
    foreach (var item in bowlingAlley)
        Console.Write(item);
    Console.WriteLine();
}

Console.Write("Введите длину ряда кегель: ");
var lenghtArray = int.Parse(Console.ReadLine() ?? "");
var bowlingAlley = MakeNewGame(lenghtArray);
Console.Write("Введите количество бросков: ");
var countStrikes = int.Parse(Console.ReadLine() ?? "");
int[] hitParams;
for (var numberStrike = 0; numberStrike < countStrikes; numberStrike++)
{
    Console.WriteLine("Введите параметры броска через пробел:");
    hitParams = (Console.ReadLine() ?? "").Split(' ').Select(int.Parse).ToArray();
    DoSrike(bowlingAlley, hitParams[0], hitParams[1]);
    PrintStatus(bowlingAlley);
}
