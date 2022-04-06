namespace eBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public int Bookquantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string Imgfile { get; set; }

    }
}
