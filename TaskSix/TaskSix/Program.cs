Console.WriteLine("Input c for C# books \nInput o for .NET core books \nInput d for clean coding books \nInput e for EFCore books");
var userOption = Console.ReadLine();

if (userOption?.ToLower() == "c")
{
    Console.WriteLine("C# books");
}
else if (userOption?.ToLower() == "o")
{
    Console.WriteLine(".NET core books");
}
else if (userOption?.ToLower() == "d")
{
    Console.WriteLine("clean coding books");
}
else if (userOption?.ToLower() == "e")
{
    Console.WriteLine("EFCore books");
}
else
{
    Console.WriteLine("Try again");
}
