namespace Invoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "provider", "customer", "article", 172);
            Console.WriteLine(invoice.GetSum());
            Console.WriteLine(invoice.GetSum(false));
        }
    }
}
