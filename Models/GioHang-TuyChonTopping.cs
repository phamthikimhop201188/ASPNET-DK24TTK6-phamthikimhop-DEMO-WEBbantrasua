C#
namespace QuanLyTraSua.Models
{
    public class CartItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }         // Size S, M, L
        public string SugarRatio { get; set; }   // 100%, 70%, 50% Đường
        public string IceRatio { get; set; }     // 100%, 70%, 50% Đá
        public string Topping { get; set; }      // Trân châu đen, Thạch trái cây, Foam kem

        public decimal Total
        {
            get { return Quantity * Price; }
        }
    }
}
