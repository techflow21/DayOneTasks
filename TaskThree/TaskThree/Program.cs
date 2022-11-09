
Console.WriteLine("Enter Date string in this format 05/January/2022 :");

var inputDate = Console.ReadLine();
Datefunction(inputDate);
Console.ReadLine();

static void Datefunction(string inputDate)
{
    try
    {
       DateTime outputDate = DateTime.Parse(inputDate);
       outputDate = outputDate.AddDays(7);
       Console.WriteLine($"7 days later, the date is: {outputDate.ToString("dd/MMMM/yyyy")}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Unable to parse the specified date");
    }
}