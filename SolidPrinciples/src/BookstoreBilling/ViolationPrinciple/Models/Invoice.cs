namespace BookstoreBilling.ViolationPrinciple.Models
{
    public class Invoice
    {
        private Book Book;
        private int Quantity;
        private double DiscountRate;
        private double TaxRate;
        private double Total;

        public Invoice(Book book, int quantity, double discountPercentage, double taxPercentage, double amount)
        {
            Book = book;
            Quantity = quantity;
            DiscountRate = discountPercentage;
            TaxRate = taxPercentage;
            Total = CalculateTotal();
        }

        public double CalculateTotal()
        {
            double price = (Book.Price - Book.Price * DiscountRate) * Quantity;

            double priceWithTaxes = price * (1 + TaxRate);

            return priceWithTaxes;
        }

        public void PrintInvoice()
        {
            Console.WriteLine(Quantity + "x " + Book.Name + " " + Book.Price + "$");
            Console.WriteLine("Discount Rate: " + DiscountRate);
            Console.WriteLine("Tax Rate: " + TaxRate);
            Console.WriteLine("Total: " + Total);
        }

        public void SaveToFile()
        {

        }
    }
}
