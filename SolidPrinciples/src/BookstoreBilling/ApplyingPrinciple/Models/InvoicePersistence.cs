namespace BookstoreBilling.ApplyingPrinciple.Models
{
    public class InvoicePersistence
    {
        private readonly Invoice invoice;

        public InvoicePersistence(Invoice invoice)
        {
            this.invoice = invoice;
        }

        public void SaveToFile(string fileName)
        {
            // Creates a file with given name and writes the invoice
        }
    }
}
