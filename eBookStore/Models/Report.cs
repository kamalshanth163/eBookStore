using System.ComponentModel;

namespace eBookStore.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Customername { get; set; }

        [DisplayName("Total Purchase Amount (LKR)")]
        public int Total { get; set; }
    }
}
