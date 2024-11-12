namespace lab12_b_1.models
{
    public class Detail
    {
        public int DetailID { get; set; }
        public int ProductID { get; set; }  // Foreign key to Product
        public int InvoiceID { get; set; }  // Foreign key to Invoice
        public int Amount { get; set; }
        public float Price { get; set; }
        public float SubTotal { get; set; }

        public Product Product { get; set; }
        public Invoice Invoice { get; set; }
    }
}
