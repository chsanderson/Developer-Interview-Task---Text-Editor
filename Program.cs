// See https://aka.ms/new-console-template for more information
string[] linesOfText = new string[4];
linesOfText[0] = "Welcome to the timewarp of programs!";
linesOfText[1] = "Applications like this were used in in the 1980s.";
linesOfText[2] = "I can't wait for User Interfaces to be invented.";
linesOfText[3] = "Then I can do much more complicated things";
string userResponse;
string[] temp;
int addNewLine;
try
{
    do
    {
        Console.WriteLine("Enter 'I' or 'L' to view lines of text");
        Console.WriteLine("Enter 'A' or 'a' along with some text to add to the lines of text");
        Console.WriteLine("Waiting for Response:");
        userResponse = Console.ReadLine();
        switch (userResponse.Substring(0, 1))
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
                            case ("A"):
                                addNewLine = linesOfText.Length + 1;
                                temp = new string[addNewLine];
                                for (int i = 0; i < (temp.Length - 1); i++)
                                {
                                    temp[i] = linesOfText[i];
                                }
                                temp[(addNewLine - 1)] = userResponse.Substring(1).Trim();
                                linesOfText = new string[addNewLine];
                                linesOfText = temp;
                                /*for (int i = 0; i < addNewLine; i++)
                                {
                                    Console.WriteLine(linesOfText[i]);
                                }*/ //This for loop displays the lines of text showing that the new line has been added
                                break;
                            case ("a"):
                                addNewLine = linesOfText.Length + 1;
                                temp = new string[addNewLine];
                                for (int i = 0; i < (temp.Length - 1); i++)
                                {
                                    temp[i] = linesOfText[i];
                                }
                                temp[(addNewLine - 1)] = userResponse.Substring(1).Trim();
                                linesOfText = new string[addNewLine];
                                linesOfText = temp;
                                /*for (int i = 0; i < addNewLine; i++)
                                {
                                    Console.WriteLine(linesOfText[i]);
                                }*/ //This for loop displays the lines of text showing that the new line has been added
                                break;
                            default:
                                break;
                        }
                    } while (userResponse.Length > 0);
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                }