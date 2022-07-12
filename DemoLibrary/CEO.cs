namespace DemoLibrary
{
    public class CEO: BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseamount = 150M;
            Salary = baseamount * rank;
        }
        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report performance!");
        }
        
        public void FireSomeone()
        {
            Console.WriteLine("You're Fired.");
        }

    }
}