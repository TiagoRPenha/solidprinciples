namespace BookstoreBilling.ApplyingPrinciple.Models
{
    public class Invoice
    {
        public Book Book;
        public int Quantity;
        public double DiscountRate;
        public double TaxRate;
        public double Total;

        public Invoice(Book book, int quantity, double discountRate, double taxRate, double total)
        {
            Book = book;
            Quantity = quantity;
            DiscountRate = discountRate;
            TaxRate = taxRate;
            Total = CalculateTotal();
        }

        public double CalculateTotal()
        {
            double price = (Book.Price - Book.Price * DiscountRate) * Quantity;

            double priceWithTaxes = price * (1 + TaxRate);

            return priceWithTaxes;
        }
    }
}
