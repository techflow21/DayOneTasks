User myObj = new();
Console.WriteLine("For Registration");

Console.WriteLine("Enter Your Username: ");
var enteredUsername = Console.ReadLine();

Console.WriteLine("Enter Your Password: ");
var enteredPassword = Console.ReadLine();

myObj.Username = enteredUsername;
myObj.Password = enteredPassword;
Console.WriteLine("Registration successful");

Console.WriteLine("Enter Yes to Login or No to Exit: ");
var loginOption = Console.ReadLine();

switch (loginOption?.ToLower())
{
    case "yes":
        {
            Console.WriteLine("Enter your Username: ");
            var loginUsername = Console.ReadLine();

            Console.WriteLine("Enter Your Password: ");
            var loginPassword = Console.ReadLine();

            if (myObj.Username != loginUsername || myObj.Password != loginPassword)
            {
                Console.WriteLine("Incorrect login details");
                break;
            }
            Console.WriteLine("Login successful");
            break;
        }
    default:
        if (loginOption?.ToLower() != "no")
        {
            Console.WriteLine("You entered invalid option");
        }
        else
        {
            Console.WriteLine("Thank you for Registering");
        }
        break;
}
class User
{
public string ?Username { get; set; }
public string ?Password { get; set; }
}
