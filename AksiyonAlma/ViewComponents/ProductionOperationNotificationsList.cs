using Business.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AksiyonAlma.ViewComponents
{
    public class ProductionOperationNotificationsList : ViewComponent
    {
        ProductionOperationNotificationsManager productionOperationNotificationsManager = new ProductionOperationNotificationsManager();
        public IViewComponentResult Invoke()
        {
            var values = productionOperationNotificationsManager.ProductionOperationList();
            return View(values);
        }
    }
}
