using AOC1;



Console.WriteLine("Hello, this is Advent Of Code 2021 1 day puzzle solution! Please enter puzzle input. Enter 'F' to finish.");
List<int> measurements = new();

while (true)
{
    var input = Console.ReadLine() ?? string.Empty;
    if (int.TryParse(input, out var parsed))
    {
        measurements.Add(parsed);
    }
    else if (input.Equals("F", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    else
    {
        Console.WriteLine("Looks like you entered something wrong. Please try again.");
    }
}

try
{
    var increases = SonarSweep.CountIncreasesWindow(measurements, 3);
    Console.WriteLine($"There are {increases} measurements that are larger than the previous measurement.");
}
catch (Exception ex)
{
    Console.WriteLine($"Sorry, something went wrong. {ex.Message}");
}



