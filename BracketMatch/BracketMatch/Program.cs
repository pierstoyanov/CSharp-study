// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Welcome to Bracket match!\n" +
    "Enter the name of a .txt in the current directory to check if opening and closing brackets match.\n" +
    "Type exit to close.\n");
Console.ResetColor();

string inputToFile = $"{Directory.GetCurrentDirectory()}\\{Console.ReadLine()}.txt";
string[] exitWords = { "q", "quit", "exit", "esc" };

while (!exitWords.Contains(inputToFile) && 
    !File.Exists(inputToFile))
{
    Console.WriteLine("File doesn't exist.");
    inputToFile = Console.ReadLine();
}

string fileString = System.IO.File.ReadAllText(inputToFile);

char[] opening = { '[', '{', '(', '<' };
char[] closing = { ']', '}', ')', '>' };

Stack<char> bracketStack = new Stack<char>();

bool result = false;

foreach (char c in fileString)
{
    if (closing.Contains(c))
    {
        var oppositeBracket = opening[Array.IndexOf(closing, c)];

        if (bracketStack.Count != 0 && oppositeBracket == bracketStack.Peek())
        {
            result = true;
            bracketStack.Pop();
            continue;
        }
        else
        {
            result = false;
            break;
        }
    }

    if (opening.Contains(c))
    {
        bracketStack.Push(c);
        result = false;
    }
}

if (bracketStack.Count > 0)
    result = false;

Console.WriteLine(result ? "True, all brackets match" : "False, brackets don't match.");
return;
