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
    public class StandartDuruslarManager : IStandartDuruslarService
    {
        public List<StandartDuruslar> duruslarListe()
        {
            List<StandartDuruslar> standartDuruslar = new List<StandartDuruslar>()
            {
                new StandartDuruslar()
                {
                    Baslangic=DateTime.ParseExact("10:00", "HH:mm", CultureInfo.InvariantCulture),                    
                    Bitis=DateTime.ParseExact("10:15", "HH:mm", CultureInfo.InvariantCulture),
                    DurusNedeni="Çay Molası"

                },
                new StandartDuruslar()
                {
                   Baslangic=DateTime.ParseExact("12:00", "HH:mm", CultureInfo.InvariantCulture),
                    Bitis=DateTime.ParseExact("12:30", "HH:mm", CultureInfo.InvariantCulture),
                    DurusNedeni="Yemek Molası"

                },
                new StandartDuruslar()
                {
                    Baslangic = DateTime.ParseExact("15:00", "HH:mm", CultureInfo.InvariantCulture),
                    Bitis = DateTime.ParseExact("15:15", "HH:mm", CultureInfo.InvariantCulture),
                    DurusNedeni="Çay Molası"

                }
            };        
            
            return standartDuruslar;
            
        }
    }
}
