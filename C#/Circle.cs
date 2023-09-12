namespace CircleTesting
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public class Circle
    {
        public enum Position { CORNER, CENTER }

        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public double Diameter
        {
            get
            {
                return radius * 2;
            }
            set
            {
                radius = value / 2;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }

        public double Circumference
        {
            get
            {
                return 2 * Math.PI * radius;
            }
        }
    }
}