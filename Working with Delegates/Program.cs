namespace Assignment8ex2
{
    public delegate void myDelegates();
    public class MathSolutions
    {
        public delegate void myDelegate();
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
            Action<int, int> calcResult = delegate (int x, int y) { Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1, num2)}"); };
            Func<int, int, int> calcResult2 = delegate (int a, int b) { return a * b; }; Console.WriteLine($" {num1} * {num2} = {answer.GetProduct(num1, num2)}");
            
            answer.GetSmaller(num1, num2);
           

        }
    }
}
