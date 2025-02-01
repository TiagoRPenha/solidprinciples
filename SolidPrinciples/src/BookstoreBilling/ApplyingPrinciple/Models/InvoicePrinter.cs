namespace BookstoreBilling.ApplyingPrinciple.Models
{
    public class InvoicePrinter
    {
        private Invoice invoice;

        public InvoicePrinter(Invoice invoice)
        {
            this.invoice = invoice;
        }

        public void print()
        {
            Console.WriteLine(invoice.Quantity + "x " + invoice.Book.Name + " " + invoice.Book.Price + "$");
            Console.WriteLine("Discount Rate: " + invoice.DiscountRate);
            Console.WriteLine("Tax Rate: " + invoice.TaxRate);
            Console.WriteLine("Total: " + invoice.Total);
        }
    }
}
