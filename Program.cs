// See https://aka.ms/new-console-template for more information
string[] linesOfText = new string[4];
linesOfText[0] = "Welcome to the timewarp of programs!";
linesOfText[1] = "Applications like this were used in in the 1980s.";
linesOfText[2] = "I can't wait for User Interfaces to be invented.";
linesOfText[3] = "Then I can do much more complicated things";
bool exit = false;
string userResponse = Console.ReadLine();
switch (userResponse)
{
    case ("I"):
        for (int i = 0; i < linesOfText.Length; i++)
        {
            Console.WriteLine(linesOfText[i]);
        }
        break;
    case ("L"):
        for (int i = 0; i < linesOfText.Length; i++)
        {
            Console.WriteLine(linesOfText[i]);
        }
        break;
    default:
        break;
}
Console.ReadLine();
