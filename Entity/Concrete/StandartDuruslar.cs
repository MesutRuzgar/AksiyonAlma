using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class StandartDuruslar : IEntity
    {
        public string Baslangic { get; set; }
        public string Bitis { get; set; }      
        public string? DurusNedeni { get; set; }
    }
}
