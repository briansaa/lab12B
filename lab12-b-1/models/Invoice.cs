namespace lab12_b_1.models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }  // Foreign key to Customer
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public float Total { get; set; }

        public Customer Customer { get; set; }
        public ICollection<Detail> Details { get; set; }
    }
}
