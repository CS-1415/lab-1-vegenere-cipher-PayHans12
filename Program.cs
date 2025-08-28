using System.Diagnostics;

bool isValid = false;
Console.Write("Please enter the message: ");
string message = Console.ReadLine();
isValid = InputIsGood(message);

while (isValid == false)
{
    Console.WriteLine("Sorry we only support lower case letters.");
    Console.Write("Please enter your message again: ");
    message = Console.ReadLine();
    isValid = InputIsGood(message);
}
Console.Write("Please enter the key: ");
string key = Console.ReadLine();
isValid = InputIsGood(key);

while (isValid == false)
{
    Console.WriteLine("Sorry we only support lower case letters.");
    Console.Write("Please enter your message again: ");
    key = Console.ReadLine();
    isValid = InputIsGood(key);
}

static bool InputIsGood(string input)
{
    char[] inputChar = input.ToCharArray();
    foreach (char letter in inputChar)
    {
        if (IsLowercaseLetter(letter));
        else
        {
            return false;
        }
        
    }
    return true;
}

// Returns true if the given character is a lowercase letter and false otherwise
static bool IsLowercaseLetter(char c)
{
    return false;
}

// static void TestIsLowercaseLetter() {
//     Debug.Assert(TestIsLowercaseLetter('a'));
//     Debug.Assert(TestIsLowercaseLetter('b'));
//     Debug.Assert(TestIsLowercaseLetter('z'));
//     Debug.Assert(!TestIsLowercaseLetter('A'));
//     Debug.Assert(!TestIsLowercaseLetter('`'));
//     Debug.Assert(!TestIsLowercaseLetter('{'));
// }