namespace NewProject
{
   public class Distance{
        private int feet;
        private int inch; 
        public Distance(int f, int i){
            feet = f;
            inch = i;
        }
        public static Distance operator +(Distance d1, Distance d2){
            int NewFeet = (d1.inch + d2.inch) / 12;
            int NewInch  = ((d1.inch + d2.inch) % 12);
            return new Distance(d1.feet + d2.feet + NewFeet, NewInch);
        }
        public void Display(){
            Console.WriteLine($"{feet} ft  {inch} in");
        }
    }
}