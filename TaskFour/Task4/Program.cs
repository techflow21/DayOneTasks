Console.WriteLine("Code implementation difference between Break and Continue ");
Console.WriteLine("Enter minimum text length of 6:");

var inputString = Console.ReadLine();
if (inputString?.Length >= 6)
{
    for (var i = 0; i <= inputString.Length; i++)
    {
        if (i == 6)
        {
            Console.WriteLine($"Input letter  for break: {inputString[i]}");
            break;
        }

        if (i % 2 != 0)
        {
            Console.WriteLine($"Input letter for Continue : {inputString[i]}");
            continue;
        }
    }
}
else
{
    Console.WriteLine("input text length too short");
}
Console.ReadLine();
