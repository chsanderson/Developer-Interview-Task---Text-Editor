// See https://aka.ms/new-console-template for more information
string[] linesOfText = new string[4];
linesOfText[0] = "Welcome to the timewarp of programs!";
linesOfText[1] = "Applications like this were used in in the 1980s.";
linesOfText[2] = "I can't wait for User Interfaces to be invented.";
linesOfText[3] = "Then I can do much more complicated things";
string userResponse;
string[] temp;
int addNewLine;
string responseTemp;
try
{
    do
    {
        Console.WriteLine("");
        Console.WriteLine("Enter 'I' or 'L' to view lines of text");
        Console.WriteLine("Enter 'A' or 'a' along with some text to add to the lines of text");
        Console.WriteLine("Enter 'i' or 'I' with a line number and the text you want to appear in that line and it will appear in that position above the text previously on  that line");
        Console.WriteLine("Waiting for Response:");
        userResponse = Console.ReadLine();
        switch (userResponse.Substring(0, 1))
        {
            case ("I"):
                                bool newLine = false;
                                try
                                {
                                    int newResponse;
                                    try
                                    {
                                        try
                                        {
                                            newResponse = Int32.Parse(userResponse.Substring(1, 4));
                                            newLine = true;
                                            if (userResponse.Length > 5)
                                            {
                                                responseTemp = userResponse.Substring(5).Trim();
                                            }
                                            else
                                            {
                                                responseTemp = " ";
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            newResponse = Int32.Parse(userResponse.Substring(1, 3));
                                            newLine = true;
                                            if (userResponse.Length > 4)
                                            {
                                                responseTemp = userResponse.Substring(4).Trim();
                                            }
                                            else
                                            {
                                                responseTemp = " ";
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        try
                                        {
                                            newResponse = Int32.Parse(userResponse.Substring(1, 2));
                                            newLine = true;
                                            if (userResponse.Length > 3)
                                            {
                                                responseTemp = userResponse.Substring(3).Trim();
                                            }
                                            else
                                            {
                                                responseTemp = " ";
                                            }
                                        }
                                        catch (Exception x)
                                        {
                                            newResponse = Int32.Parse(userResponse.Substring(1, 1));
                                            newLine = true;
                                            if (userResponse.Length > 2)
                                            {
                                                responseTemp = userResponse.Substring(2);
                                            }
                                            else
                                            {
                                                responseTemp = " ";
                                            }

                                        }
                                    }
                    int tempI = 0; ;
                                    if (newLine == true)
                                    {
                        int lines = newResponse - linesOfText.Length;
                                        addNewLine = lines;
                                        temp = new string[addNewLine];
                                        for (int i = 0; i < (newResponse - 1); i++)
                                        {
                                            temp[i] = linesOfText[i];
                            tempI = i;
                                        }
                                        temp[newResponse - 1] = responseTemp;
                                        for (int i = tempI + 1; i < temp.Length; i++)
                                        {
                                            temp[i] = linesOfText[i - 1];
                                        }
                                        linesOfText = temp;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect Command");
                                    }
                                }
                                catch (Exception ex)
                                {
                    Console.WriteLine("Number to Big");//ex.ToString());
                                }
                                for (int i = 0; i < linesOfText.Length; i++)
                                {
                                    Console.WriteLine(linesOfText[i]);
                                }
                break;

            case ("i"):
                 newLine = false;
                try
                {
                    int newResponse;
                    try
                    {
                        try
                        {
                            newResponse = Int32.Parse(userResponse.Substring(1, 4));
                            newLine = true;
                            if (userResponse.Length > 5)
                            {
                                responseTemp = userResponse.Substring(5).Trim();
                            }
                            else
                            {
                                responseTemp = " ";
                            }
                        }
                        catch (Exception ex)
                        {
                            newResponse = Int32.Parse(userResponse.Substring(1, 3));
                            newLine = true;
                            if (userResponse.Length > 4)
                            {
                                responseTemp = userResponse.Substring(4).Trim();
                            }
                            else
                            {
                                responseTemp = " ";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            newResponse = Int32.Parse(userResponse.Substring(1, 2));
                            newLine = true;
                            if (userResponse.Length > 3)
                            {
                                responseTemp = userResponse.Substring(3).Trim();
                            }
                            else
                            {
                                responseTemp = " ";
                            }
                        }
                        catch (Exception x)
                        {
                            newResponse = Int32.Parse(userResponse.Substring(1, 1));
                            newLine = true;
                            if (userResponse.Length > 2)
                            {
                                responseTemp = userResponse.Substring(2);
                            }
                            else
                            {
                                responseTemp = " ";
                            }

                        }
                    }
                        int tempI = 0; ;
                        if (newLine == true)
                        {
                            int lines = newResponse - linesOfText.Length;
                            addNewLine = lines;
                            temp = new string[addNewLine];
                        for (int i = 0; i < (newResponse - 1); i++)
                        {
                            temp[i] = linesOfText[i];
                            tempI = i;
                        }
                                temp[newResponse - 1] = responseTemp;
                        for (int i = tempI + 1; i < temp.Length; i++)
                        {
                            temp[i] = linesOfText[i - 1];
                        }
                        linesOfText = temp;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Command");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Number to Big"); //(ex.ToString());
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