// Program.cs
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
        static void Main(string[] args)
        {
            OverRideOp();

        }
    }
}
