// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World2!");
Console.WriteLine("Hello, World3!");
Console.WriteLine("Hello, World4!");

int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAverage(numbers));
double avg = GetAverage([
    1,2,3,4,5
]);

double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}
