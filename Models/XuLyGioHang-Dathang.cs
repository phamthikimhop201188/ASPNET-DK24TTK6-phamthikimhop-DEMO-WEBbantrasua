C#
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using QuanLyTraSua.Models;

namespace QuanLyTraSua.Controllers
{
    public class CartController : Controller
    {
        // Lấy giỏ hàng từ Session
        public List<CartItem> GetCart()
        {
            List<CartItem> cart = Session["Cart"] as List<CartItem>;
            if (cart == null)
            {
                cart = new List<CartItem>();
                Session["Cart"] = cart;
            }
            return cart;
        }

        // Thêm trà sữa vào giỏ hàng với các tùy chọn
        public ActionResult AddToCart(int id, string size, string sugar, string ice, string topping)
        {
            List<CartItem> cart = GetCart();
            CartItem item = cart.FirstOrDefault(p => p.ProductID == id && p.Size == size);

            if (item == null)
            {
                cart.Add(new CartItem
                {
                    ProductID = id,
                    ProductName = "Trà Sữa Trân Châu Hoàng Gia",
                    Price = 35000,
                    Quantity = 1,
                    Size = size ?? "M",
                    SugarRatio = sugar ?? "100%",
                    IceRatio = ice ?? "100%",
                    Topping = topping ?? "Trân châu đen"
                });
            }
            else
            {
                item.Quantity++;
            }
            return RedirectToAction("Index");
        }

        // Xem trang Giỏ hàng
        public ActionResult Index()
        {
            List<CartItem> cart = GetCart();
            ViewBag.TotalAmount = cart.Sum(item => item.Total);
            return View(cart);
        }

        // Xóa sản phẩm khỏi giỏ hàng
        public ActionResult RemoveItem(int id)
        {
            List<CartItem> cart = GetCart();
            CartItem item = cart.FirstOrDefault(p => p.ProductID == id);
            if (item != null)
            {
                cart.Remove(item);
            }
            return RedirectToAction("Index");
        }
    }
}
