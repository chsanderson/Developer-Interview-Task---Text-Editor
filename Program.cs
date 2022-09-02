﻿// See https://aka.ms/new-console-template for more information

//Christopher Sanderson
//31/08/2022
using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;


//Initializing the global variables
string[] linesOfText = new string[1];//string array used to keep record of the lines of text
//linesOfText[0] = "Welcome to the timewarp of programs!";
//linesOfText[1] = "Applications like this were used in in the 1980s.";
//linesOfText[2] = "I can't wait for User Interfaces to be invented.";
//linesOfText[3] = "Then I can do much more complicated things";

String line;// this will be used to read tread the current line that is being added from the text file you have selected
string userResponse;//this is the global variable that will store the users input
string[] temp;//temporary array that will help to edit the order of the lines
int addNewLine;
string responseTemp;
string folderName = @"c:\ChristopherSanderson-TextEditor";//file path where the text files will be stored
string pathString = System.IO.Path.Combine(folderName);
StreamWriter streamWriter;
string fileName;//this is the global variable for the file name


//attempting to create directory if it does not already exist
//Requirement 7
try
{
    System.IO.Directory.CreateDirectory(pathString);
    fileName = "file.txt";
    pathString = System.IO.Path.Combine((folderName), fileName);

    if (!System.IO.File.Exists(pathString))
    {
        using (System.IO.FileStream fs = System.IO.File.Create(pathString)) ;
    }
    else
    {
        //Console.WriteLine("file already exists", fileName);
    }
    fileName = "";
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
    fileName = "file.txt";
    pathString = System.IO.Path.Combine((folderName), fileName);

    if (!System.IO.File.Exists(pathString))
    {
        using (System.IO.FileStream fs = System.IO.File.Create(pathString)) ;
    }
    else
    {
        //Console.WriteLine("file already exists", fileName);
    }
    fileName = "";
}

try
{
    //loop that will repeat until the user taps the enter button more than once in succession
    do
    {
        //User Instructions
        Console.WriteLine("");
        Console.WriteLine("Enter 'L' to Load lines of text from file that you specify before you submit the command. otherwise it will load file.txt or if you are currently using it the file you have just used");
        Console.WriteLine("Enter 'I' to view lines of text");
        Console.WriteLine("Enter 'A' or 'a' along with some text to add a new line of text");
        Console.WriteLine("Enter 'I' or 'i' with a line number and the text you want to appear in that line and it will appear in that position above the text previously on  that line");
        Console.WriteLine("Enter 'D' or 'd' with a line number and when submitted the line will be deleted");
        Console.WriteLine("Enter 'R' or 'r' with the first line number and then a space and the next line number and to flip them.");
        Console.WriteLine("Enter 'E' or 'e' with the line number you want to edit and then supply the text you want to change the line number to and submit.");
        Console.WriteLine("Enter 'S' to save the lines of text to a file that you specify before you submit the command. otherwise it will load file.txt or if you are currently using it the file you have just used");
        Console.WriteLine("Waiting for Response:");


        userResponse = Console.ReadLine(); //Gets the user input from the console
        
        switch (userResponse.Substring(0, 1))//this checks the first character from the user response that has been given above
        {
            //Requirement 1 + 3
            case ("I"):// case I will load and display each item in the array linesOfText to the user through the console
                //this if case will be carried out if the user has added any charcters after I which will then be inserted into the array if they have given a number of line they want insert it to 
                if (userResponse.Length > 1)
                {
                    bool newLine = false;
                    try
                    {
                        int newResponse;
                        //these check if there has been any numbers given after I
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
                        //this sorts the previous array into another new version of the array
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
                        break;
                    }
                }
                Console.WriteLine("Insert has been completed");
                //this loads the linesOfText array and displays each item on the console one after the other
                for (int i = 0; i < linesOfText.Length; i++)
                {
                    Console.WriteLine(linesOfText[i]);
                }
                break;
                //Requirement 3
            case ("i"):
                //this if case will be carried out if the user has added any charcters after I which will then be inserted into the array if they have given a number of line they want insert it to 
                if (userResponse.Length >1)
                { 
                    bool newLine = false;
                try
                {
                    int newResponse;

                        //these check if there has been any numbers given after I
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

                        //this sorts the old array into a new version of the same array
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
                        break;
                    Console.WriteLine("");//ex.ToString());
                } }
                Console.WriteLine("Insert has been completed");
                break;

                //Requirement 1 + 7
                    case ("L"): 
                //loading the the text file into a new array and saving the previous array to that file
                if(fileName == "")
                {
                    try
                    {
                        fileName = userResponse.Substring(1) + ".txt";
                    }
                    catch(Exception ex)
                    {

                        fileName = "file.txt";
                    }

                }
                else
                {
                    fileName = fileName;
                    //this saves the previous list to the previous text file being used
                    string pathString3;
                    if (userResponse.Trim().Length > 1)
                    {
                        pathString3 = System.IO.Path.Combine(folderName);
                        pathString3 = System.IO.Path.Combine((folderName), fileName);

                        if (!System.IO.File.Exists(pathString3))
                        {
                            using (System.IO.FileStream fs = System.IO.File.Create(pathString3)) ;
                        }
                        else
                        {
                            Console.WriteLine("file already exists", fileName);
                        }
                        streamWriter = new StreamWriter(pathString3);
                    }
                    else
                    {
                        streamWriter = new StreamWriter(pathString);
                        pathString3 = pathString;
                    }
                    for (int i = 0; i < linesOfText.Length; i++)
                    {
                        streamWriter.WriteLine(linesOfText[i]);
                    }
                    streamWriter.Close();

                }


                StreamReader newStreamReader;
                string pathString2;
                linesOfText = new string[1];
                if (userResponse.Trim().Length > 1)
                {
                    //this specifies the text file that has the lines have to be saved to and loaded to and that the file path where these are stored is 'C:ChristopherSanderson-TextEditor'
                    fileName = userResponse.Substring(1) + ".txt";
                    pathString2 = System.IO.Path.Combine((folderName));
                    pathString2 = System.IO.Path.Combine((folderName), fileName);

                    if (!System.IO.File.Exists(pathString2))
                    {
                        using (System.IO.FileStream fs = System.IO.File.Create(pathString2));
                    }
                    else
                    {
                        Console.WriteLine("file already exists", fileName);
                    }
                     newStreamReader = new StreamReader(pathString2);
                }
                else {
                     newStreamReader = new StreamReader(pathString);
                    pathString2 = pathString;
                }
                line = newStreamReader.ReadLine();
                int count = 0 ;
                while (line != null)
                {
                    count++;
                    temp = new string[count];
                    temp[count - 1] = line;
                    if(count > 1)
                    {
                        for(int i = 0; i < count-1;i++)
                        {
                            temp[i] = linesOfText[i];
                        }
                        linesOfText = new string[count];
                        linesOfText = temp;
                    }
                    linesOfText[count-1] = line;
                    Console.WriteLine(line);
                    line = newStreamReader.ReadLine();
                }
                newStreamReader.Close();
                //Console.ReadLine();

                /* for (int i = 0; i < linesOfText.Length; i++)
                 {
                     Console.WriteLine(linesOfText[i]);
                 }*/
                break;


            case ("A"):
                //Requirement 2 this allows the user to add a new line of text below the current set of lines
                if (linesOfText.Length == 1 && linesOfText[0] == "")
                {
                    linesOfText[0] = userResponse.Substring(1);
                }
                addNewLine = linesOfText.Length + 1;
                temp = new string[addNewLine];
                for (int i = 0; i < (temp.Length - 1); i++)
                {
                    temp[i] = linesOfText[i];
                }
                temp[(addNewLine - 1)] = userResponse.Substring(1).Trim();
                linesOfText = new string[addNewLine];
                linesOfText = temp;
            Console.WriteLine("New line has been created");
                /*for (int i = 0; i < addNewLine; i++)
                {
                    Console.WriteLine(linesOfText[i]);
                }*/ //This for loop displays the lines of text showing that the new line has been added
                break;
                
            case ("a"):
            //Requirement 2 this allows the user to add a new line of text below the current set of lines
                        if (linesOfText.Length == 1 && linesOfText[0] == "")
                        {
                            linesOfText[0] = userResponse.Substring(1);
                        }
                        addNewLine = linesOfText.Length + 1;
                        temp = new string[addNewLine];
                        for (int i = 0; i < (temp.Length - 1); i++)
                        {
                            temp[i] = linesOfText[i];
                        }
                        temp[(addNewLine - 1)] = userResponse.Substring(1).Trim();
                        linesOfText = new string[addNewLine];
                        linesOfText = temp;
                Console.WriteLine("New line has been created");
                        /*for (int i = 0; i < addNewLine; i++)
                        {
                            Console.WriteLine(linesOfText[i]);
                        }*/ //This for loop displays the lines of text showing that the new line has been added
                        break;



            case ("d"):
                //requirement 4 this allows the user to delete a row they specify a number for starting with the first row (row 1)
                int deletedRow = 0;
                if (userResponse.Length >= 2)
                {
                    try
                    {
                        deletedRow = Int32.Parse(userResponse.Substring(1));
                        if (deletedRow > linesOfText.Length || deletedRow < 0)
                        {
                            Console.WriteLine("Row cannot be deleted as it doesn't exist");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invalid Command! Text is in this command");
                        break;
                    }
                    deletedRow = Int32.Parse(userResponse.Substring(1));
                }
                string[] temporaryArray = new string[linesOfText.Length - 1];
                for (int i = 0; i < deletedRow; i++)
                {
                    temporaryArray[i] = linesOfText[i];
                }
                for (int i = deletedRow; i < temporaryArray.Length; i++)
                {
                    temporaryArray[i] = linesOfText[i + 1];
                }
                linesOfText = new string[temporaryArray.Length];
                linesOfText = temporaryArray;
                Console.WriteLine("Row has been deleted");
                Console.WriteLine("");
                break;

            case ("D"):
                //requirement 4 this allows the user to delete a row they specify a number for starting with the first row (row 1)
                deletedRow = 0;
                if (userResponse.Length >= 2)
                {
                    try
                    {
                        deletedRow = Int32.Parse(userResponse.Substring(1));
                        if (deletedRow > linesOfText.Length || deletedRow < 0)
                        {
                            Console.WriteLine("Row cannot be deleted as it doesn't exist");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invalid Command! Text is in this command");
                    }
                    deletedRow = Int32.Parse(userResponse.Substring(1));
                }
                    temporaryArray = new string[linesOfText.Length - 1];
                for (int i = 0; i < deletedRow; i++)
                {
                    temporaryArray[i] = linesOfText[i];
                }
                for (int i = deletedRow; i < temporaryArray.Length; i++)
                {
                    temporaryArray[i] = linesOfText[i + 1];
                }
                linesOfText = new string[temporaryArray.Length];
                linesOfText = temporaryArray;
                Console.WriteLine("Row has been deleted");
                Console.WriteLine("");
                break;

            case ("R"):
                //Requirement 5 this allows the user to swap around lines they specifiy numbers for that are within the amount of lines that are being displayed on the console
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
                Console.WriteLine("Lines have been swapped");
                Console.WriteLine("");
                break;
            case ("r"):
                //Requirement 5 this allows the user to swap around lines they specifiy numbers for that are within the amount of lines that are being displayed on the console
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
                Console.WriteLine("Lines have been swapped");
                Console.WriteLine("");
                break;

            case ("E"):
                //Requirement 6
                //this allows users to edit the line they specify a number for
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
                            //this displays error messages to the console for the user to read
                            if (listnumber <= 0)
                            {
                                Console.WriteLine("You haven't specified a line to edit");
                                break;
                            }
                            if (listnumber >= linesOfText.Length)
                            {
                                Console.WriteLine("Line you have asked to edit doesn't exist");
                                break;
                            }
                            linesOfText[listnumber - 1] = userResponse.Substring(4);
                        }
                        catch (Exception e)
                        {
                            try
                            {
                                listnumber = Int32.Parse(userResponse.Substring(1, 2));
                                linesOfText[listnumber - 1] = userResponse.Substring(3);

                                //this displays error messages to the console for the user to read
                                if (listnumber <= 0)
                                {
                                    Console.WriteLine("You haven't specified a line to edit");
                                    break;
                                }
                                if (listnumber >= linesOfText.Length)
                                {
                                    Console.WriteLine("Line you have asked to edit doesn't exist");
                                    break;
                                }
                            }
                            catch (Exception x)
                            {
                                listnumber = Int32.Parse(userResponse.Substring(1, 1));
                                //this displays error messages to the console for the user to read
                                if (listnumber <= 0)
                                {
                                    Console.WriteLine("You haven't specified a line to edit");
                                    break;
                                }
                                if (listnumber >= linesOfText.Length)
                                {
                                    Console.WriteLine("Line you have asked to edit doesn't exist");
                                    break;
                                }
                                linesOfText[listnumber - 1] = userResponse.Substring(2);
                            }
                        }
                    }
                }
                Console.WriteLine("Line has been edited");
                Console.WriteLine("");
                break;
            case ("e"):
                //Requirement 6
                //this allows users to edit the line they specify a number for
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
                            //this displays error messages to the console for the user to read
                            if (listnumber <= 0)
                            {
                                Console.WriteLine("You haven't specified a line to edit");
                                break;
                            }
                            if (listnumber >= linesOfText.Length)
                            {
                                Console.WriteLine("Line you have asked to edit doesn't exist");
                                break;
                            }
                            linesOfText[listnumber - 1] = userResponse.Substring(4);
                        }
                        catch (Exception e)
                        {
                            try
                            {
                                listnumber = Int32.Parse(userResponse.Substring(1, 2));
                                linesOfText[listnumber - 1] = userResponse.Substring(3);

                                //this displays error messages to the console for the user to read
                                if (listnumber <= 0)
                                {
                                    Console.WriteLine("You haven't specified a line to edit");
                                    break;
                                }
                                if (listnumber >= linesOfText.Length)
                                {
                                    Console.WriteLine("Line you have asked to edit doesn't exist");
                                    break;
                                }
                            }
                            catch (Exception x)
                            {
                                listnumber = Int32.Parse(userResponse.Substring(1, 1));
                                //this displays error messages to the console for the user to read
                                if (listnumber <= 0)
                                {
                                    Console.WriteLine("You haven't specified a line to edit");
                                    break;
                                }
                                if (listnumber >= linesOfText.Length)
                                {
                                    Console.WriteLine("Line you have asked to edit doesn't exist");
                                    break;
                                }
                                linesOfText[listnumber - 1] = userResponse.Substring(2);
                            }
                        }
                    }
                }
                Console.WriteLine("Line has been edited");
                Console.WriteLine("");
                break;

            case ("S")://Requirement 7
                //this saves the files to the text file they were using
                if (fileName == "")
                {
                    if (fileName == "")
                    {
                        try
                        {
                            fileName = userResponse.Substring(1) + ".txt";
                        }
                        catch (Exception ex)
                        {

                            fileName = "file.txt"; //Console.WriteLine(ex.ToString());
                        }
                    }
                    else
                    {
                        fileName = fileName;
                    }
                }
                else {
                    string pathString4;
                    if (userResponse.Trim().Length > 1)
                    {
                        fileName = userResponse.Substring(1) + ".txt";
                        pathString4 = System.IO.Path.Combine(folderName, "Text Editor Storage");
                        pathString4 = System.IO.Path.Combine((folderName), fileName);

                        if (!System.IO.File.Exists(pathString4))
                        {
                            using (System.IO.FileStream fs = System.IO.File.Create(pathString4)) ;
                        }
                        else
                        {
                            Console.WriteLine("file already exists", fileName);
                        }
                        streamWriter = new StreamWriter(pathString4);
                    }
                    else
                    {
                        streamWriter = new StreamWriter(pathString);
                        pathString4 = pathString;
                    }
                    for (int i = 0; i < linesOfText.Length; i++)
                    {
                        streamWriter.WriteLine(linesOfText[i]);
                    }
                    streamWriter.Close();
                }
                Console.WriteLine("Lines have been saved to the file you have been using");
                Console.WriteLine("");
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