namespace lab12_b_1.models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public ICollection<Detail> Detail { get; set; }
        public bool IsDeleted { get; internal set; }
    }
}
