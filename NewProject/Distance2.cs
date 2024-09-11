namespace NewProject
{
   public class Distance2{
            private Double dist;
            private Double inch;
        public Distance2(Double dist, Double inch = 0){
            this.dist = dist;
            this.inch = inch;
        }
        public static Distance2 operator +(Distance2 d1, Distance2 d2){
            Double Total =  d1.dist + d2.dist;
            int feet = (int)Math.Floor(Total);
            Double inch = Math.Round((Total - feet) * 12,2);
             return new Distance2(feet, inch);

        }
              public void Display(){
            Console.WriteLine($"{dist}ft {inch}inch");
        }

   }
}