namespace lab12_b_1.models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
        public bool IsDeleted { get; internal set; }
    }
}
