namespace Encapsulations
{
    public class Bank
    {
        private double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Money Should not be Negative");
                }
                else
                {
                    balance = value;
                }
            }
        }
    }
    class Encapsulation
    {
        public static void Main()
        {
            Bank icici = new Bank();
            icici.Balance = 625600;
            Console.WriteLine(icici.Balance);
            icici.Balance = -76400;
            Console.WriteLine(icici.Balance);
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}