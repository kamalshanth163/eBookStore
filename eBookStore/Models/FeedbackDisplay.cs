namespace eBookStore.Models
{
    public class FeedbackDisplay
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string UserName { get; set; }
        public string FeedbackText { get; set; }
        public decimal Rating { get; set; }
        public string Imgfile { get; set; }
    }
}
