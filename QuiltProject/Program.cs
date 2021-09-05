using System;
using System.Collections.Generic;
using System.Text;

namespace QuiltProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var display = new StringBuilder();
           // display.AppendLine("\nNo items in the List").ToString();   //has logical error displays the content irrespectively

            
            bool next = true;
            var color = "";

            var pattern = new QuiltPattern(color);

            var ui = new UserInputs();
            Console.WriteLine("Welcome to the Quilt pattern selector!\n");
            
            ui.select();
            Console.Write("Please select an option : ");
            var shape = Console.ReadLine();
            Console.WriteLine();                //empty line

            do
            {
                if (shape != "L")
                {
                    Console.Write("Please enter a color : ");
                    color = Console.ReadLine();
                }
                switch (shape)
                {
                    case "L":
                        if (display.Length == 0)
                        {
                            Console.WriteLine("No items in the List");
                            break;
                        }
                        Console.WriteLine(display);
                        break;

                    case "S":
                        pattern = new SquarePattern(color);
                        display.AppendLine($"{pattern.Color} {pattern.Name} with area: {pattern.getArea()}");
                        break;

                    case "R":
                        pattern = new RectangularPattern(color);
                        display.AppendLine($"{pattern.Color} {pattern.Name} with area: {pattern.getArea()}");
                        break;

                    case "T":
                        pattern = new TriangularPattern(color);
                        display.AppendLine($"{pattern.Color} {pattern.Name} with area: {pattern.getArea()}");
                        break;
                    default:
                        display.AppendLine("\nInvalid pattern selection!!!");
                        break;
                }
                Console.Write("\nEnter \"YES\" to continue, \"NO\" to exit : ");
                next = ui.doContinue(Console.ReadLine().Trim().ToUpper());
                Console.WriteLine();                        //empty line

                if (next)
                {
                    ui.select();
                    Console.Write("\nPlease select an option : ");
                    shape = Console.ReadLine();
                }
            } while (next);
            /*
            #region PatternsList
		 var patterns = new List<QuiltPattern>
            {
                new SquarePattern("Square Pattern", "Red"),
                new RectangularPattern("Rectangular Pattern", "Green"),
                new TriangularPattern("Triangular Pattern", "Orange"),
            };
            foreach (var pattern in patterns)
            {
                Console.WriteLine($"{pattern.Color} {pattern.Name} with area: {pattern.getArea()}");

            } 
            #endregion 
            */

            Console.WriteLine(display);
        }
    }
}
