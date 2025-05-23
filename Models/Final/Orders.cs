namespace EqDemo.AspNetCoreReact.AdvancedSearch.Models.Final
{
    public class Orders
    {
        public int orderId { get; set; }
        public int userId { get; set; }
        public int productId { get; set; }
        public string address { get; set; }
        public decimal orderAmount { get; set; }
    }
}
