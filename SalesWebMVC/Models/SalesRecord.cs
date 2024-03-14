using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
    }
}
