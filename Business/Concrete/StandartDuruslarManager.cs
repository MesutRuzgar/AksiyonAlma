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
                    Baslangic="10:00",                    
                    Bitis="10:15",
                    DurusNedeni="Çay Molası"

                },
                new StandartDuruslar()
                {
                   Baslangic="12:00",
                    Bitis="12:30",
                    DurusNedeni="Yemek Molası"

                },
                new StandartDuruslar()
                {
                    Baslangic="15:00",
                    Bitis="15:15",
                    DurusNedeni="Çay Molası"

                }
            };        
            
            return standartDuruslar;
            
        }
    }
}
