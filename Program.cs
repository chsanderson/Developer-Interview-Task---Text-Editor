// See https://aka.ms/new-console-template for more information

//Christopher Sanderson
//31/08/2022
using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

string[] linesOfText = new string[4];
//linesOfText[0] = "Welcome to the timewarp of programs!";
//linesOfText[1] = "Applications like this were used in in the 1980s.";
//linesOfText[2] = "I can't wait for User Interfaces to be invented.";
//linesOfText[3] = "Then I can do much more complicated things";
string userResponse;
string[] temp;
int addNewLine;
string responseTemp;
try
{
    do
    {
        Console.WriteLine("");
        Console.WriteLine("Enter 'L' to Load lines of text from file");
        Console.WriteLine("Enter 'I' to view lines of text");
        Console.WriteLine("Enter 'A' or 'a' along with some text to add a new line of text");
        Console.WriteLine("Enter 'I' or 'i' with a line number and the text you want to appear in that line and it will appear in that position above the text previously on  that line");
        Console.WriteLine("Enter 'D' or 'd' with a line number and when submitted the line will be deleted");
        Console.WriteLine("Enter 'R' or 'r' with the first line number and then a space and the next line number and to flip them.");
        Console.WriteLine("Enter 'E' or 'e' with the line number you want to edit and then supply the text you want to change the line number to and submit.");
        Console.WriteLine("Enter 'E' or 'e' with the line number you want to edit and then supply the text you want to change the line number to and submit.");
        Console.WriteLine("Enter 'S' to save the lines of text to a file");

        Console.WriteLine("Waiting for Response:");
        userResponse = Console.ReadLine();
        switch (userResponse.Substring(0, 1))
        {
            case ("I"):
                if (userResponse.Length > 1)
                {
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
                        int tempI = 0;
                        if (newLine == true && linesOfText.Length >= 1)
                        {
                                int lines = newResponse - linesOfText.Length;
                                addNewLine = lines;
                                temp = new string[lines + linesOfText.Length];
                            if (newResponse > linesOfText.Length)
                            {
                                for (int i = 0; i < (linesOfText.Length - 1); i++)
                                {
                                    temp[i] = linesOfText[i];
                                    tempI = i;
                                }
                                temp[newResponse - 1] = responseTemp;
                            }
                            else
                            {
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
                            }
                            linesOfText = new string[temp.Length];
                            linesOfText = temp;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Command");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Number to Big cannot be done");
                        Console.WriteLine("");//ex.ToString());
                    }
                }

                String line;
                /*try
                {
                    StreamReader streamReader = new StreamReader("C:\\Users\\ChSan\\source\\repos\\Developer Interview Task - Text Editor\\file.txt");
                    line = streamReader.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = streamReader.ReadLine();
                    }
                    streamReader.Close();
                    Console.ReadLine();
                
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }*/
                
                for (int i = 0; i < linesOfText.Length; i++)
                {
                    Console.WriteLine(linesOfText[i]);
                }
                break;

            case ("i"):
            if(userResponse.Length >1)
                { 
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
                    int tempI = 0;
                    if (newLine == true)
                    {
                        int lines = newResponse - linesOfText.Length;
                        addNewLine = lines;
                        temp = new string[lines + linesOfText.Length];
                        if (newResponse > linesOfText.Length)
                        {
                            for (int i = 0; i < (linesOfText.Length - 1); i++)
                            {
                                temp[i] = linesOfText[i];
                                tempI = i;
                            }
                            temp[newResponse - 1] = responseTemp;
                        }
                        else
                        {
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
                        }
                        linesOfText = new string[temp.Length];
                        linesOfText = temp;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Command");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Number to Big cannot be done");
                    Console.WriteLine("");//ex.ToString());
                } }

                break;
                    case ("L"):
                StreamReader newStreamReader = new StreamReader("C:\\Users\\ChSan\\source\\repos\\Developer Interview Task - Text Editor\\file.txt");
                line = newStreamReader.ReadLine();
                int count = 0 ;
                while (line != null)
                {
                    linesOfText[count] = line;
                    if(count >=4)
                    {
                        temp = new string[count + 1];
                        for(int i = 0; i <= count;i++)
                        {
                            temp[i] = linesOfText[i];
                        }
                        linesOfText = temp;
                    }
                    linesOfText[count] = line;
                    Console.WriteLine(line);
                    line = newStreamReader.ReadLine();
                    count++;
                }
                newStreamReader.Close();
                //Console.ReadLine();

                /* for (int i = 0; i < linesOfText.Length; i++)
                 {
                     Console.WriteLine(linesOfText[i]);
                 }*/
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



            case ("d"):
                int deletedRow = 0;
                if(userResponse.Length>=2)
                {
                    try
                    {
                        deletedRow = Int32.Parse(userResponse.Substring(1));
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Invalid Command! Text is in this command");
                    }
                    deletedRow = Int32.Parse(userResponse.Substring(1));
                }
                string[] temporaryArray = new string[linesOfText.Length - 1];
                for(int i = 0; i<deletedRow;i++)
                {
                    temporaryArray[i] = linesOfText[i];
                }
        for (int i = deletedRow; i<temporaryArray.Length;i++)
                {
                    temporaryArray[i] = linesOfText[i + 1];
                }
                linesOfText = new string[temporaryArray.Length];
                linesOfText = temporaryArray;
                break;

            case ("R"):
                if (userResponse.Length > 1)
                {
                    int firstnumberTemp = 0;
                    int secondnumberTemp = 0;
                    int trimNumber = 0;
                    try
                    {
                        for (int i = 1; i < userResponse.Length - 1; i++)
                        {
                            int firstnumber = 0;
                            try
                            {
                                firstnumber = Int32.Parse(userResponse.Substring(1, i));
                            }
                            catch (Exception ex)
                            {
                                firstnumber = Int32.Parse(userResponse.Substring(1, i + 1));
                            }

                            if (firstnumber <= linesOfText.Length)
                            {
                                firstnumberTemp = firstnumber;
                            }
                            else
                            {
                                trimNumber = i;
                                i = userResponse.Length;
                            }
                        }
                        for (int i = 2; i < userResponse.Length; i++)
                        {
                            int secondnumber = 0;
                            try
                            {
                                secondnumber = Int32.Parse(userResponse.Substring(i));
                            }
                            catch (Exception ex)
                            {
                                secondnumber = Int32.Parse(userResponse.Substring(i + 1));
                            }
                            if (secondnumber <= linesOfText.Length)
                            {
                                secondnumberTemp = secondnumber;
                                i = userResponse.Length;
                            }
                        }
                        string replacementOne = linesOfText[firstnumberTemp - 1];
                        string replacementTwo = linesOfText[secondnumberTemp - 1];
                        linesOfText[secondnumberTemp - 1] = replacementOne;
                        linesOfText[firstnumberTemp - 1] = replacementTwo;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                break;
            case ("r"):
                if (userResponse.Length > 1)
                {
                    int firstnumberTemp = 0;
                    int secondnumberTemp = 0;
                    int trimNumber = 0;
                    try
                    {
                        for (int i = 1; i < userResponse.Length - 1 ; i++)
                        {
                            int firstnumber = 0;
                            try
                            {
                                firstnumber = Int32.Parse(userResponse.Substring(1, i));
                            }
                            catch(Exception ex)
                            {
                                firstnumber = Int32.Parse(userResponse.Substring(1, i+1));
                            }

                            if(firstnumber <= linesOfText.Length)
                            {
                                firstnumberTemp = firstnumber;
                            }
                            else
                            {
                                trimNumber = i;
                                i = userResponse.Length;
                            }
                        }
                        for (int i = 2; i < userResponse.Length; i++)
                        {
                            int secondnumber = 0;
                            try
                            {
                                secondnumber = Int32.Parse(userResponse.Substring(i));
                            }
                            catch (Exception ex)
                            {
                                secondnumber = Int32.Parse(userResponse.Substring(i +1));
                            }
                            if (secondnumber <= linesOfText.Length)
                            {
                                secondnumberTemp = secondnumber;
                                i = userResponse.Length;
                            }
                        }
                        string replacementOne = linesOfText[firstnumberTemp - 1];
                        string replacementTwo = linesOfText[secondnumberTemp - 1];
                        linesOfText[secondnumberTemp - 1] = replacementOne;
                        linesOfText[firstnumberTemp - 1] = replacementTwo;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                break;



            case ("E"):
                if (userResponse.Length > 1)
                {
                    int listnumber = 0;
                    try
                    {
                        listnumber = Int32.Parse(userResponse.Substring(1, 4));
                        linesOfText[listnumber - 1] = userResponse.Substring(5);
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            listnumber = Int32.Parse(userResponse.Substring(1, 3));
                            linesOfText[listnumber - 1] = userResponse.Substring(4);
                        }
                        catch (Exception e)
                        {
                            try
                            {
                                listnumber = Int32.Parse(userResponse.Substring(1, 2));
                                linesOfText[listnumber - 1] = userResponse.Substring(3);
                            }
                            catch (Exception x)
                            {
                                listnumber = Int32.Parse(userResponse.Substring(1, 1));
                                linesOfText[listnumber - 1] = userResponse.Substring(2);
                            }
                        }
                    }

                }
                break;
            case ("e"):
                if (userResponse.Length > 1)
                {
                    int listnumber = 0;
                    try
                    {
                        listnumber = Int32.Parse(userResponse.Substring(1, 4));
                        linesOfText[listnumber - 1] = userResponse.Substring(5);
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            listnumber = Int32.Parse(userResponse.Substring(1, 3));
                            linesOfText[listnumber - 1] = userResponse.Substring(4);
                        }
                        catch (Exception e)
                        {
                            try
                            {
                                listnumber = Int32.Parse(userResponse.Substring(1, 2));
                                linesOfText[listnumber - 1] = userResponse.Substring(3);
                            }
                            catch (Exception x)
                            {
                                listnumber = Int32.Parse(userResponse.Substring(1, 1));
                                linesOfText[listnumber - 1] = userResponse.Substring(2);
                            }
                        }
                    }
                }
                break;

            case ("S"):
                StreamWriter streamWriter = new StreamWriter("C:\\Users\\ChSan\\source\\repos\\Developer Interview Task - Text Editor\\file.txt");
                for (int i = 0; i < linesOfText.Length; i++)
                {
                    streamWriter.WriteLine(linesOfText[i]);
                }
                streamWriter.Close();
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