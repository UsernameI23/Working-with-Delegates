namespace Assignment8ex2
{
    public delegate double myDelegate(double x, double y);
    public class MathSolutions
    {
        //public delegate void myDelegate();
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        
        
        static void Main(string[] args)
        {
            // create a class object
           

            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);

            Action<double, double> calcResult = answer.GetSmaller;
            calcResult(num1, num2);
            Func<double, double, double> calcResult2 = answer.GetProduct;
            Console.WriteLine($"{num1} x {num2} = {calcResult2(num1, num2)}");

            myDelegate calcResult3 = new myDelegate(answer.GetSum);
            Console.WriteLine($"{num1} + {num2} = {calcResult3(num1, num2)}");
            //answer.GetSmaller(num1, num2);
           

        }
    }
}
