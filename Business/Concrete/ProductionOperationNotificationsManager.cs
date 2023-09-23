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
    public class ProductionOperationNotificationsManager : IProductionOperationNotificationsService
    {
        public List<ProductionOperationNotifications> ProductionOperationList()
        {
            List<ProductionOperationNotifications> productionOperationNotifications = new List<ProductionOperationNotifications>()
            {
                new ProductionOperationNotifications()
                {
                   ID = 1,
                   Start = DateTime.ParseExact("05/23/20 07:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Finish = DateTime.ParseExact("05/23/20 08:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   TotalTime = DateTime.ParseExact("05/23/20 08:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture) - DateTime.ParseExact("05/23/20 07:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Status = StatusEnum.Production,
                   ReasonForStopping = ""
                },
                new ProductionOperationNotifications()
                {
                   ID = 2,
                   Start = DateTime.ParseExact("05/23/20 08:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Finish = DateTime.ParseExact("05/23/20 12:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   TotalTime = DateTime.ParseExact("05/23/20 12:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture) - DateTime.ParseExact("05/23/20 08:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Status = StatusEnum.Production,
                   ReasonForStopping = ""
                },
                new ProductionOperationNotifications()
                {
                    ID = 3,
                    Start = DateTime.ParseExact("05/23/20 12:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                    Finish = DateTime.ParseExact("05/23/20 13:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                    TotalTime = DateTime.ParseExact("05/23/20 13:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture) - DateTime.ParseExact("05/23/20 12:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                    Status = StatusEnum.Production,
                    ReasonForStopping = ""
                },
                new ProductionOperationNotifications()
                {
                   ID = 4,
                   Start = DateTime.ParseExact("05/23/20 13:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Finish = DateTime.ParseExact("05/23/20 13:45", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   TotalTime = DateTime.ParseExact("05/23/20 13:45", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture) - DateTime.ParseExact("05/23/20 13:00", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Status = StatusEnum.Stance,
                   ReasonForStopping = "Arıza"
                },
                new ProductionOperationNotifications()
                {
                   ID = 5,
                   Start = DateTime.ParseExact("05/23/20 13:45", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Finish = DateTime.ParseExact("05/23/20 17:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   TotalTime = DateTime.ParseExact("05/23/20 17:30", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture) - DateTime.ParseExact("05/23/20 13:45", "MM/dd/yy HH:mm", CultureInfo.InvariantCulture),
                   Status = StatusEnum.Production,
                   ReasonForStopping = ""
                }
            };

            return productionOperationNotifications;
        }
    }
}
