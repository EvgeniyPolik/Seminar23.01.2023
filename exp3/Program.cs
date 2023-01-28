string[,] MakeFlate(int size)
{
    var result = new string[size,size];
    for (var i = 0; i < size; i++)
        for (var j = 0; j < size; j++)
            result[i, j] = ".";
    return result;
}

void MakeSnowflake(string[,] flate)
{
    var size = flate.GetLength(0);
    var decriment = size;
    for (var i = 0; i < size; i++)
    {
        decriment--;  
        for (var j = 0; j < size; j++)
            {
                if (i == j)
                    flate[i, j] =  "*";
                if (i == size / 2 - 1)
                    flate[i + 1, j] =  "*";
                if (j == size / 2 - 1)
                    flate[i, j + 1] =  "*";
                if (j == decriment)
                    flate[i, j] =  "*";
            }          
    }   
}

void PrintSnowflake(string[,] flate)
{
    var size = flate.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
            Console.Write(flate[i,j]);
        Console.WriteLine();
    }
}

Console.Write("Введите размер снежинки: ");
var n = int.Parse(Console.ReadLine() ?? "");
var flate = MakeFlate(n);
MakeSnowflake(flate);
PrintSnowflake(flate);
