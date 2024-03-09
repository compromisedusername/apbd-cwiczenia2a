// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World2!");
Console.WriteLine("Hello, World3!");
Console.WriteLine("Hello, World4!");
Console.WriteLine("HotFix!");
Console.WriteLine("SecondHotFix!");
int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAverage(numbers));
double avg = GetAverage([
    1,2,3,4,5
]);


Console.WriteLine(GetAverage(numbers));
double max = GetAverage([
    1,2,3,4,5
]);


static double GetAverage(int[] numbers)
{
    int TheSum = 0;
    foreach (var number in numbers)
    {
        TheSum += number;
    }

    return TheSum / numbers.Length;
}

static double GetMax(int[] numbers)
{
    int max = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (max < numbers[i])
            max = numbers[i];
    }
    
    return max;
}
