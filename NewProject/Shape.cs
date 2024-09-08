namespace NewProject
{
class Shape
    {
        private double l, b,r;
        protected Shape(double r){
            this.r = r;
            Console.Write(r + "HEy");
        }
        protected Shape(double l, double b){
            this.l = l;
            this.b = b;
        }

        public double FindAreaCircle(){
        return  (22.0/ 7.0) * Math.Pow(r, 2);
    }

        public double FindAreaPolygan(bool rect = true){
            double multiplier = rect ? 1.0 : 0.5;
            return  multiplier * l * b;
        }
             

    }
}