using Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AksiyonAlma.ViewComponents
{
    public class StandartDuruslarList : ViewComponent
    {
        StandartDuruslarManager standartDuruslarManager = new StandartDuruslarManager();
        public IViewComponentResult Invoke()
        {
            var values = standartDuruslarManager.duruslarListe();
            return View(values);
        }
    }
}
