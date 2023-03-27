namespace invoiceManager.Domain
{
    public class Costumer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public DateTime DateOfCreation { get; set; }
        public Costumer()
        {
            Invoices = new List<Invoice>();
        }

    }
}
