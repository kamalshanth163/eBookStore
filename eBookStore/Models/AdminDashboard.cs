namespace eBookStore.Models
{
    public class AdminDashboard
    {
        public int Id { get; set; }
        public int TotalCustomers { get; set; }
        public int TotalAdmins { get; set; }
        public int TotalBooks { get; set; }
        public int TotalOrders { get; set; }
        public int TotalPendingOrders { get; set; }
        public int TotalCompletedOrders { get; set; }

    }
}
