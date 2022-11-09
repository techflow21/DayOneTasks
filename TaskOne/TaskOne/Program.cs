namespace TaskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string returned;
            string outputText = "";
            string frontchars;
           // bool startAgain = true;

            Console.WriteLine("Enter text");

            string inputText = Console.ReadLine();
            inputText.ToLower();

           
            if(inputText.Length > 4 )
            {
                frontchars = inputText.Substring(0, inputText.Length - 4);
                returned = inputText.Substring(inputText.Length - 4);

                foreach (char hash in frontchars)
                {
                    outputText += '#';
                }

                foreach (char charLetter in returned)
                {

                    outputText += charLetter;
                }

                Console.WriteLine(outputText);

            }
            else
            {
                Console.WriteLine("input letters less than four");
            }

            Console.ReadLine();
        }
    }
}