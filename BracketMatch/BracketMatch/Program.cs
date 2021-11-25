// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string input = Console.ReadLine();
string[] exitWords = { "q", "quit", "exit", "esc" };

while (!exitWords.Contains(input) && !System.IO.File.Exists(input))
{
    Console.WriteLine("File doesn't exist.");
    input = Console.ReadLine();
}

string fileString = System.IO.File.ReadAllText(input);

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
    }
}

Console.WriteLine(result ? "True, all brackets match" : "False, brackets don't match.");
return;
