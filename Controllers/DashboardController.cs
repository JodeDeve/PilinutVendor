using Microsoft.AspNetCore.Mvc;
using PilinutVendorSystem.Models;
using PilinutVendorSystem.Services;

namespace PilinutVendorSystem.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IInventoryService _inventoryService;

        public DashboardController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        public IActionResult Index()
        {
            var model = _inventoryService.GetDashboard();
            return View(model);
        }
    }
}
