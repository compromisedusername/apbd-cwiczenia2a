// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World2!");
Console.WriteLine("Hello, World3!");
Console.WriteLine("Hello, World4!");

double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}
