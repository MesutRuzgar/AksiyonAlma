using Business.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UretimOperasyonBildirimleriManager : IUretimOperasyonBildirimleriService
    {
        public List<UretimOperasyonBildirimleri> uretimListe()
        {
            List<UretimOperasyonBildirimleri> uretimOperasyon = new List<UretimOperasyonBildirimleri>()
            {
                new UretimOperasyonBildirimleri()
                {
                   KayitNo = 1,
                   Baslangic = DateTime.ParseExact("05/23/20 07:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Bitis = DateTime.ParseExact("05/23/20 08:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   ToplamSure = DateTime.ParseExact("05/23/20 08:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture) - DateTime.ParseExact("05/23/20 07:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Statu = StatuEnum.Uretim,
                   DurusNedeni = ""
                },
                new UretimOperasyonBildirimleri()
                {
                   KayitNo = 2,
                   Baslangic = DateTime.ParseExact("05/23/20 08:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Bitis = DateTime.ParseExact("05/23/20 12:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   ToplamSure = DateTime.ParseExact("05/23/20 12:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture) - DateTime.ParseExact("05/23/20 08:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Statu = StatuEnum.Uretim,
                   DurusNedeni = ""
                },
                new UretimOperasyonBildirimleri()
                {
                   KayitNo = 3,
                   Baslangic = DateTime.ParseExact("05/23/20 12:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Bitis = DateTime.ParseExact("05/23/20 13:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   ToplamSure = DateTime.ParseExact("05/23/20 13:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture) - DateTime.ParseExact("05/23/20 12:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Statu = StatuEnum.Uretim,
                   DurusNedeni = ""
                },
                new UretimOperasyonBildirimleri()
                {
                   KayitNo = 4,
                   Baslangic = DateTime.ParseExact("05/23/20 13:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Bitis = DateTime.ParseExact("05/23/20 13:45", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   ToplamSure = DateTime.ParseExact("05/23/20 13:45", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture) - DateTime.ParseExact("05/23/20 13:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Statu = StatuEnum.Durus,
                   DurusNedeni = "Arıza"
                },
                new UretimOperasyonBildirimleri()
                {
                   KayitNo = 5,
                   Baslangic = DateTime.ParseExact("05/23/20 13:45", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Bitis = DateTime.ParseExact("05/23/20 17:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   ToplamSure = DateTime.ParseExact("05/23/20 17:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture) - DateTime.ParseExact("05/23/20 13:45", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Statu = StatuEnum.Uretim,
                   DurusNedeni = ""
                }
            };

            return uretimOperasyon;
        }
    }
}
