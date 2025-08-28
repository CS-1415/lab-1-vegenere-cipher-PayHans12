//Payton Hansen
//Lab 01

using System.Data;
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

string shiftedMessage = MessageShift(message, key);
Console.WriteLine($"Here is the encrypted message:\n {shiftedMessage}");

static bool InputIsGood(string input)
{
    char[] inputChar = input.ToCharArray();
    foreach (char letter in inputChar)
    {
        if (IsLowercaseLetter(letter)) ;
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
    int charIntValue = Convert.ToInt32(c);
    for (int i = 97; i <= 122; i++)
    {
        if (c == i)
        {
            return true;
        }
    }
    return false;
}
static string MessageShift(string message, string key)
{
    char[] messageLetters = message.ToCharArray();
    char[] keyLetters = key.ToCharArray();
    int count = 0;
    foreach (char letter in messageLetters)
    {
        LetterShift(letter, keyLetters[count]);
        count++;
        if (count >= keyLetters.Length)
        {
            count = 0;
        }
    }

}
static char LetterShift(char message, char key)
{
    return message;
}

// static void TestIsLowercaseLetter() {
//     Debug.Assert(TestIsLowercaseLetter('a'));
//     Debug.Assert(TestIsLowercaseLetter('b'));
//     Debug.Assert(TestIsLowercaseLetter('z'));
//     Debug.Assert(!TestIsLowercaseLetter('A'));
//     Debug.Assert(!TestIsLowercaseLetter('`'));
//     Debug.Assert(!TestIsLowercaseLetter('{'));
// }