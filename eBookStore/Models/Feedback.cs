namespace eBookStore.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public string FeedbackText { get; set; }
        public decimal Rating { get; set; }
    }
}
