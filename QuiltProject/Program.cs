using System;
using System.Collections.Generic;
using System.Text;

//************************************************************************************************
//QuiltProject lets the user make pattern selection from the provided list.
//Any Invalid pattern selection gives an Invalid selection warning and loop back.
//Each of the pattern classes are instantiated and appropriate action is being taken.
//Could get the derived classes instance added to the base class List<T> earlier, so took a different route of execution.
//Will consider refactoring this code when time permits later on.
//Out of curiosity, I have also tested ForegroundColor settings in few places to see how it works
//Program prompts user to continue or exit upon the completion of first loop
//************************************************************************************************

namespace QuiltProject
{
    class Program
    {
        static void Main(string[] args)
        {

            QuiltPattern pattern;
            var display = new StringBuilder();
                       
            bool next = true; var color = "";

            var ui = new UserInputs();
            Console.WriteLine("Welcome to the Quilt pattern selector!\n");

            do
            {
                ui.SelectPattern();
                Console.Write("Please select an option : ");
                var shape = Console.ReadLine().Trim().ToUpper();  //Trims the white spaces and set the input to all upper Case.
                Console.WriteLine(); //empty line

                #region Pattern Selection
                try
                {
                    switch (shape)
                    {
                        case "L":
                            if (display.Length == 0)
                            {
                                Console.WriteLine("No items in the List");
                                break;
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Current QuiltPattern List :\n{ display.ToString()}");
                            Console.ResetColor();
                            break;

                        case "S":

                            Console.WriteLine("You have selected Square Pattern.");
                            color = ui.GetString("\nEnter color of your Square : ");
                            pattern = new SquarePattern(color);
                            display.AppendLine($"{pattern.Color} {pattern.Name} with area: {pattern.GetArea()}");
                            break;

                        case "R":
                            Console.WriteLine("You have selected Rectangular Pattern.");
                            color = ui.GetString("\nEnter color of your Rectangle : ");
                            pattern = new RectangularPattern(color);
                            display.AppendLine($"{pattern.Color} {pattern.Name} with area: {pattern.GetArea()}");
                            break;

                        case "T":
                            Console.WriteLine("You have selected Triangular Pattern.");
                            color = ui.GetString("\nEnter color of your Triangle : ");
                            pattern = new TriangularPattern(color);
                            display.AppendLine($"{pattern.Color} {pattern.Name} with area: {pattern.GetArea()}");
                            break;

                        default:
                            Console.WriteLine("Invalid pattern selection!!!");
                            break;
                    }
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }
                #endregion

                Console.Write("\nEnter \"YES\" to continue, \"NO\" to exit : ");
                next = ui.doContinue(Console.ReadLine().Trim().ToUpper());
                Console.WriteLine(); //empty line

            } while (next);

            Console.ForegroundColor = ConsoleColor.DarkGreen;           
            Console.WriteLine("Final QuiltPattern List:\n{0}\nThank you!", display.ToString());
            Console.ResetColor();

            /* 
            #region PatternList
            List<QuiltPattern> patterns = new List<QuiltPattern>();

            var square = new SquarePattern(color);
            square.CreateSquarePattern();
            patterns.Add(square);

            var rectangle = new RectangularPattern(color);

            var triangle = new TriangularPattern(color);



             triangle.CreateRectangularPattern();
             patterns.Add(triangle);
             Console.WriteLine($"{square.Color} {square.Name} with area: {square.GetArea()}");   //testing the prints

            foreach (var pattern in patterns)
            {
                Console.WriteLine($"{pattern.Color} {pattern.Name} with area: {pattern.GetArea()}");  //this failed to print the Name and Area correctly
            } 
            #endregion
            */

            //var pattern = new QuiltPattern(color);

        }
    }
}
