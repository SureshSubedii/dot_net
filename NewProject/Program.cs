// Program.cs
using static System.Console;
namespace NewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> areas = new Dictionary<int, string>{
               { 1, "Circle"},
               { 2, "Triangle"},
               { 3, "Rectangle"},

            };
            int choice = 0;
            double result;


            while (choice != 4)
            {
                try
                {
                    WriteLine("Select any one \n 1. Area Of circle \n 2.Area Of Triangle \n 3.Area Of Rectangle \n 4.exit");
                    _ = int.TryParse(ReadLine(), out choice);
                    if (choice == 4) break;

                    string areaOf = areas[choice];
                    if (choice == 1)
                    {
                        WriteLine("Enter Radius Of circle");
                        _ = double.TryParse(ReadLine(), out double radius);
                        Circle circle = new(radius);
                        result = circle.FindAreaCircle();
                    }
                    else
                    {
                        WriteLine($"Enter length and breadth  Of {areaOf} ");
                        _ = double.TryParse(ReadLine(), out double length);
                        _ = double.TryParse(ReadLine(), out double breadth);
                        if (choice == 2)
                        {
                            Triangle triangle = new(length, breadth);
                            result = triangle.FindAreaPolygan(false);
                        }
                        else
                        {
                            Rectangle rect = new(length, breadth);
                            result = rect.FindAreaPolygan();

                        }
                    }
                    WriteLine($"The area of {areaOf} is {result} \n");
                }

                catch (KeyNotFoundException e)
                {
                    WriteLine("Enter Valid Number!");

                }
            }







        }
    }
}
