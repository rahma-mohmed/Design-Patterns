namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Write("Enter base currency: ");
                string baseCurrency = Console.ReadLine();
                Console.Write("Enter target currency: ");
                string target = Console.ReadLine();
                Console.Write("Enter amount: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                //var convertor = new CurrencyConvertor();
                var res = CurrencyConvertor.Instance.Covert(baseCurrency, target, amount);
                Console.WriteLine(res);
                Console.WriteLine("------------------------------------------------------------------");
            }
         
        }
    }
}
