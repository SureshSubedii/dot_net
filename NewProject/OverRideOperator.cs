using static System.Console;

namespace NewProject
{
    class OverRideOperator
    {

        private int _a;

        public int A
        {
            get { return _a; }
            set
            {_a = value;}

        }
        private int _b;
        public int B
        {
            get { return _b; }
            set
            {_b = value;}
        }
        public OverRideOperator(int a, int b)
        {
            A = a;
            B = b;

        }
        public static OverRideOperator operator -(OverRideOperator o)
        {
            return new OverRideOperator(-o.A, -o.B);

        }
        public override string ToString()
        {
             return $" Point {A} {B}";
        }
    }
}