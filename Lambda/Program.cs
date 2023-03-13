namespace FunwithLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val1 = double.Parse(Console.ReadLine());
            double val2 = double.Parse(Console.ReadLine());
            var sumResult = (double val1, double val2) =>
            {
                double calcSum = val1 + val2;
                return calcSum;
            };
            var multResult = (double val1, double val2) =>
            {
                double calcSum = val1 * val2;
                return calcSum;
            };
            var compareResult = (double val1, double val2) =>
            {
                double calcSum = 0;
                if (val1 > val2)
                { calcSum = val2; }
                else
                {
                  calcSum = val1;
                }
                return calcSum;
            };
            Console.WriteLine("Sum--");
            Console.WriteLine(sumResult(val1, val2));
            Console.WriteLine("Multiply--");
            Console.WriteLine(multResult(val1, val2));
            Console.WriteLine("Compare--");
            Console.WriteLine(compareResult(val1, val2));
            Console.ReadLine();
        }
    }
}