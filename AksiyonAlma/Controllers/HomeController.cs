using AksiyonAlma.Models;
using Business.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace AksiyonAlma.Controllers
{
    public class HomeController : Controller
    {
        StandardStancesManager standardStancesManager = new StandardStancesManager();
        ProductionOperationNotificationsManager productionOperationNotificationsManager = new ProductionOperationNotificationsManager();

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult GetAction()
        {
            var productionOperations = productionOperationNotificationsManager.ProductionOperationList();
            var standardStances = standardStancesManager.StandardStancesList();

            List<ProductionOperationNotifications> yeniOperasyonBildirimleri = new List<ProductionOperationNotifications>();

            foreach (var po in productionOperations)
            {
                var breaks = standardStances.Where(x => x.Start.TimeOfDay >= po.Start.TimeOfDay && x.Finish.TimeOfDay <= po.Finish.TimeOfDay).ToList();

                if (breaks.Count > 0)
                {
                    DateTime previousEnding = po.Start;

                    var poStartDate = po.Start.ToShortDateString();
                    var poFinishDate = po.Finish.ToShortDateString();

                    foreach (var b in breaks)
                    {
                        var breakStartTime = b.Start.ToShortTimeString();
                        var breakFinishTime = b.Finish.ToShortTimeString();

                        var breakStart = DateTime.Parse(poStartDate + " " + breakStartTime);
                        var breakFinish = DateTime.Parse(poStartDate + " " + breakFinishTime);

                        if (previousEnding.TimeOfDay == b.Start.TimeOfDay)
                        {
                            yeniOperasyonBildirimleri.Add(new ProductionOperationNotifications
                            {
                                ID = po.ID,
                                Start = breakStart,
                                Finish = breakFinish,
                                TotalTime = b.Finish.TimeOfDay - b.Start.TimeOfDay,
                                Status = StatusEnum.Stance,
                                ReasonForStopping = b.ReasonForStopping
                            });
                        }
                        else
                        {
                            yeniOperasyonBildirimleri.Add(new ProductionOperationNotifications
                            {
                                ID = po.ID,
                                Start = previousEnding,
                                Finish = breakStart,
                                TotalTime = b.Start.TimeOfDay - previousEnding.TimeOfDay,
                                Status = po.Status,
                                ReasonForStopping = po.ReasonForStopping
                            });
                            yeniOperasyonBildirimleri.Add(new ProductionOperationNotifications
                            {
                                ID = po.ID,
                                Start = breakStart,
                                Finish = breakFinish,
                                TotalTime = b.Finish.TimeOfDay - b.Start.TimeOfDay,
                                Status = StatusEnum.Stance,
                                ReasonForStopping = b.ReasonForStopping
                            });
                        }
                        previousEnding = breakFinish;
                    }
                    if (previousEnding.TimeOfDay < po.Finish.TimeOfDay)
                    {
                        yeniOperasyonBildirimleri.Add(new ProductionOperationNotifications
                        {
                            ID = po.ID,
                            Start = previousEnding,
                            Finish = po.Finish,
                            TotalTime = po.Finish.TimeOfDay - previousEnding.TimeOfDay,
                            Status = po.Status,
                            ReasonForStopping = po.ReasonForStopping
                        });
                    }
                }
                else
                {
                    yeniOperasyonBildirimleri.Add(po);
                }
            }
            var values = JsonConvert.SerializeObject(yeniOperasyonBildirimleri);
            return Json(values);
        }
    }


}



