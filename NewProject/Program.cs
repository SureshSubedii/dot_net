﻿// Program.cs
using static System.Console;
namespace NewProject
{
    class Program
    {

        static void FindArea()
        {
            Shape.FindArea();


        }

        static void OverRideOp()
        {

            OverRideOperator o = new(10, 20);
            OverRideOperator o1 = -o;
            WriteLine($"{o}{o1}");

        }
        static void SumDistance()
        {
            WriteLine("Enter the first distance in feet and inch");
            _ = int.TryParse(ReadLine(), out int FirstFeet);
            _ = int.TryParse(ReadLine(), out int FirstInch);

            WriteLine("Enter the second distance in feet and inch");
            _ = int.TryParse(ReadLine(), out int SecondFeet);
            _ = int.TryParse(ReadLine(), out int SecondInch);

            Distance d1 = new(FirstFeet, FirstInch);
            Distance d2 = new(SecondFeet, SecondInch);
            Distance d3 = d1 + d2;
            d3.Display();



        }

        static void Main(string[] args)
        {
            SumDistance();
        }
    }
}
