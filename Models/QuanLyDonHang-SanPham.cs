C#
using System.Web.Mvc;
using QuanLyTraSua.Models;

namespace QuanLyTraSua.Controllers
{
    public class AdminController : Controller
    {
        // Trang Dashboard Quản trị
        public ActionResult Index()
        {
            return View();
        }

        // Danh sách quản lý sản phẩm trà sữa
        public ActionResult ManageProducts()
        {
            return View();
        }

        // Cập nhật trạng thái đơn hàng (Đang pha chế / Đang giao / Đã hoàn thành)
        [HttpPost]
        public ActionResult UpdateOrderStatus(int orderId, string status)
        {
            // Code cập nhật trạng thái vào SQL Server
            ViewBag.Message = "Cập nhật trạng thái đơn hàng thành công!";
            return RedirectToAction("ManageOrders");
        }
    }
}
