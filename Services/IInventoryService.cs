using System.Collections.Generic;
using PilinutVendorSystem.Models;

namespace PilinutVendorSystem.Services
{
    public interface IInventoryService
    {
        IEnumerable<InventoryItem> GetAll();
        InventoryItem? GetById(int id);
        InventoryItem Add(InventoryItem item);
        void Update(InventoryItem item);
        bool Delete(int id);
        DashboardViewModel GetDashboard();
    }
}
