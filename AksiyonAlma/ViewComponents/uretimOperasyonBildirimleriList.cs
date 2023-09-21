using Business.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AksiyonAlma.ViewComponents
{
    public class uretimOperasyonBildirimleriList : ViewComponent
    {
        UretimOperasyonBildirimleriManager uretimOperasyonBildirimleri = new UretimOperasyonBildirimleriManager();
        public IViewComponentResult Invoke()
        {
            var values = uretimOperasyonBildirimleri.uretimListe();
            return View(values);
        }
    }
}
