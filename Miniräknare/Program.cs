class Program
{
    static void Main()
    {
        
        bool runProgram = true;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("----Welcome To My Calculator----");
        Console.WriteLine("");

        while (runProgram)
        {
            // Printing Out The Calculating Methods

            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(")");
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("+");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(")");
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(")");
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("*");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(")");
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("SQR");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(")");
            
            // Asking Which Method That Should Be Used
            Console.WriteLine("");
            Console.WriteLine("Please Choose One Of The Methods Above");
            Console.WriteLine("To Quit, Just Write Quit");
            Console.WriteLine("");
            Console.Write(">>");
            string? calculatingMethod = Console.ReadLine();
            bool countLoop = true;

            // CountLoop Is Responsible For Taking In
            // Either 1 or 2 Numbers
            // (Depending On What Calculation Method Was Chosen)
            while (countLoop)
            {
                // Check If The Input Is Valid 
                if (calculatingMethod == "+" || calculatingMethod == "-" || calculatingMethod == "*" || calculatingMethod == "/" || calculatingMethod?.ToLower() == "sqr")
                {
                    Console.Clear();
                    string? number1;
                    string? number2;

                    // If User Wants To Use Square Root
                    if (calculatingMethod?.ToLower() == "sqr")
                    {
                        double number1Formated = 0;
                        Console.WriteLine("Please Type One Number That Will Be Used To Calculate With");
                        Console.WriteLine("");
                        Console.Write(">>");
                        number1 = Console.ReadLine();
                        bool validNumber = false;
                        // This Loop Will Secure The Code For Wrong Inputs
                        while (!validNumber)
                        {
                            try
                            {
                                number1Formated = Convert.ToDouble(number1);
                                validNumber = true;
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.Write("'");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(number1);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("' Was Not Considered To Be A Valid Input");
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Write a Number, Nothing Else");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("");
                                Console.Write(">>");
                                number1 = Console.ReadLine();
                            }
                        }
                        Console.Clear();
                        Console.Write("SQR(");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(number1);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(") = ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(Math.Sqrt(number1Formated));
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.ReadLine();
                        Console.Clear();
                        countLoop = false;
                        

                    }

                    // If User Wants To Use Either + - / *
                    if (calculatingMethod == "+" || calculatingMethod == "-" || calculatingMethod == "/" || calculatingMethod == "*")
                    {
                        Console.WriteLine("Please Type Two Numbers That Will Be Calculated With");
                        Console.WriteLine("");
                        Console.WriteLine("They Will Be Counted With The Order You Type Them");
                        Console.WriteLine("");
                        Console.Write("Number 1 >>");
                        number1 = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Number 2 >>");
                        number2 = Console.ReadLine();
                        Console.Clear();
                        bool numberLoop = false;
                        double number1Conv = 0;
                        double number2Conv = 0;
                        bool number1ConvSucc;
                        bool number2ConvSucc;
                        // This Loop Will Ensure That The User Types Numbers And Something Else
                        do {
                            // Checks If Number 1 Can Be Converted From String To Double
                            try
                            {
                                number1Conv = Convert.ToDouble(number1);
                                number1ConvSucc = true;
                            }   
                            // If Not, The Program Marks It
                            catch (FormatException)
                            {
                                number1ConvSucc = false;
                            }
                            // Checks If Number 2 Can Be Converted From String To Double
                            try
                            {
                                number2Conv = Convert.ToDouble(number2);
                                number2ConvSucc = true;
                            }
                            // If Not, The Program Marks It
                            catch (FormatException)
                            {
                                number2ConvSucc = false;
                            }

                            // These If Statements Will Check If Any Of The Numbers Are Marked
                            // If They Are, The User Will Be Asked To Retype One Or Both Numbers

                            // If Both Numbers Got Marked
                            if (number1ConvSucc == false && number2ConvSucc == false)
                            {

                                Console.Clear();
                                Console.Write("'");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(number1);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("'");
                                Console.Write(" << ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Not a Valid Input");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("");
                                Console.Write("'");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(number2);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("'");
                                Console.Write(" << ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Not a Valid Input");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("");
                                Console.WriteLine("Please Retype Both Numbers");
                                Console.Write("");
                                Console.Write("Number 1 >>");
                                number1 = Console.ReadLine();
                                Console.WriteLine("");
                                Console.Write("Number 2 >>");
                                number2 = Console.ReadLine();
                            }
                            // If Number 1 Got Marked
                            if (number1ConvSucc == false && number2ConvSucc == true) 
                            {
                                Console.Clear();
                                Console.Write("'");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(number1);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("'");
                                Console.Write(" << ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Not a Valid Input");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("");
                                Console.Write("'");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write(number2);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("'");
                                Console.Write(" << ");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Valid Input");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("");
                                Console.WriteLine("Please Retype Number 1");
                                Console.WriteLine("");
                                Console.Write("Number 1 >>");
                                number1 = Console.ReadLine();
                            }
                            // If Number 2 Got Marked
                            if (number1ConvSucc == true && number2ConvSucc == false)
                            {
                                Console.Clear();
                                Console.Write("'");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write(number1);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("'");
                                Console.Write(" << ");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Valid Input");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("");
                                Console.Write("'");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(number2);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("'");
                                Console.Write(" << ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Not a Valid Input");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("");
                                Console.WriteLine("Please Retype Number 2");
                                Console.WriteLine("");
                                Console.Write("Number 2 >>");
                                number2 = Console.ReadLine();
                            }

                            // If Both Numbers Can Succesfully Be Converted, The Loop Ends
                            // And Continues To The Calculation Switch
                            if (number1ConvSucc == true && number2ConvSucc)
                            {
                                numberLoop = true;
                            }


                        } while (!numberLoop);


                        // This Switch Statement Looks At The Calculation Method
                        // The User Chose And Prints Out The Result
                        switch (calculatingMethod)
                        {

                            case "+":
                                Console.Clear();
                                Console.Write(number1Conv + " ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(calculatingMethod + " ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(number2Conv + " = ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(number1Conv + number2Conv);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.ReadLine();
                                Console.Clear();
                                countLoop = false;
                                break;

                            case "-":
                                Console.Clear();
                                Console.Write(number1Conv + " ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(calculatingMethod + " ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(number2Conv + " = ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(number1Conv - number2Conv);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.ReadLine();
                                Console.Clear();
                                countLoop = false;
                                break;

                            case "/":
                                Console.Clear();
                                Console.Write(number1Conv + " ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(calculatingMethod + " ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(number2Conv + " = ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(number1Conv / number2Conv);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.ReadLine();
                                Console.Clear();
                                countLoop = false;
                                break;

                            case "*":
                                Console.Clear();
                                Console.Write(number1Conv + " ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(calculatingMethod + " ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(number2Conv + " = ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(number1Conv * number2Conv);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.ReadLine();
                                Console.Clear();
                                countLoop = false;
                                break;

                            default:
                                Console.WriteLine("Something Broke :)");
                                break;
                        }
                    }
                }

                // If The User Types Quit, This If Statement Gets Run
                // And Converts Both CountLoop And runProgram to false
                // Which Stops The Code
                if (calculatingMethod?.ToLower() == "quit")
                {
                    countLoop = false;
                    runProgram = false;
                }
                
                // If User Is Annoying And Doesnt Write The Right Input
                else

                {
                    // If User Didnt Write Anything Or Just Typed Spaces
                    if (calculatingMethod == "" || calculatingMethod == null || calculatingMethod == " " || calculatingMethod == "  " || calculatingMethod == "   ")
                    {
                        Console.Clear();
                        Console.WriteLine("Please Type a Valid Input");
                        Console.WriteLine("");
                        Console.WriteLine("Not Writing Anything Is Not a Valid Input");
                        Console.WriteLine("");
                        Console.WriteLine("Now Please Choose One Of These Options");
                        Console.WriteLine("");

                        Console.Write("(");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("-");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(")");
                        Console.Write("(");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("+");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(")");
                        Console.Write("(");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("/");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(")");
                        Console.Write("(");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("*");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(")");
                        Console.Write("(");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("SQR");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(")");
                        Console.WriteLine("");
                        Console.Write(">>");
                        calculatingMethod = Console.ReadLine();
                        Console.Clear();
                    }

                    // If User Typed Something Else Then What Was Shown
                    if (calculatingMethod != "+" && calculatingMethod != "-" && calculatingMethod != "*" &&
                        calculatingMethod != "/" && calculatingMethod?.ToLower() != "sqr" && calculatingMethod?.ToLower() != "quit")
                    {
                        Console.Clear();
                        Console.WriteLine("Please Type a Valid Input");
                        Console.WriteLine("");
                        Console.Write("'");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(calculatingMethod);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("', Was Not a Valid Input");
                        Console.WriteLine("");
                        Console.WriteLine("Now Please Choose One Of These Options");
                        Console.WriteLine("");

                        Console.Write("(");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("-");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(")");
                        Console.Write("(");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("+");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(")");
                        Console.Write("(");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("/");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(")");
                        Console.Write("(");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("*");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(")");
                        Console.Write("(");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("SQR");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(")");
                        Console.WriteLine("");
                        Console.Write(">>");
                        calculatingMethod = Console.ReadLine();
                        Console.Clear();
                    }

                }

            }

            // Calculation Loop Ends, Which Loops Around
            // And Starts Everything Over Again
        }

        // When runProgram Gets Set To False, The Code Quits
        // Because There Is No More Loops Or Code To Run
    }
}