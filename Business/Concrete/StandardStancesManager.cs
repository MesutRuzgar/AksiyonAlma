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
    public class StandardStancesManager : IStandardStancesService
    {
        public List<StandardStances> StandardStancesList()
        {
            List<StandardStances> standardStances = new List<StandardStances>()
            {
                new StandardStances()
                {
                    Start=DateTime.ParseExact("10:00", "HH:mm", CultureInfo.InvariantCulture),                    
                    Finish=DateTime.ParseExact("10:15", "HH:mm", CultureInfo.InvariantCulture),
                    ReasonForStopping="Çay Molası"

                },
                new StandardStances()
                {
                    Start=DateTime.ParseExact("12:00", "HH:mm", CultureInfo.InvariantCulture),
                    Finish=DateTime.ParseExact("12:30", "HH:mm", CultureInfo.InvariantCulture),
                    ReasonForStopping="Yemek Molası"

                },
                new StandardStances()
                {
                    Start = DateTime.ParseExact("15:00", "HH:mm", CultureInfo.InvariantCulture),
                    Finish = DateTime.ParseExact("15:15", "HH:mm", CultureInfo.InvariantCulture),
                    ReasonForStopping="Çay Molası"

                }
            };        
            
            return standardStances;
            
        }
    }
}
