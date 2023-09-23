using Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AksiyonAlma.ViewComponents
{
    public class StandardStancesList : ViewComponent
    {
        StandardStancesManager standardStancesManager = new StandardStancesManager();
        public IViewComponentResult Invoke()
        {
            var values = standardStancesManager.StandardStancesList();
            return View(values);
        }
    }
}
