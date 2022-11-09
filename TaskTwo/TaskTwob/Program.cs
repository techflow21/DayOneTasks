
var inputText = Console.ReadLine();
            
List<int> outputText = new List<int>();

for (int i = 0; i < inputText.Length; i++)
{
    if (inputText[i] >= 'A' & inputText[i] <= 'Z')
    {
        outputText.Add(i);
    }
}

foreach (int outputItem in outputText)
{
    Console.WriteLine($"{outputItem} : {inputText[outputItem]}");
}

Console.ReadLine();
