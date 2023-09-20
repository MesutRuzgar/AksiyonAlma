using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class UretimOperasyonBildirimleri : IEntity
    {
        public int KayitNo { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public TimeSpan ToplamSure { get; set; }
        public StatuEnum Statu { get; set; }
        public string? DurusNedeni { get; set; }
    }
}
