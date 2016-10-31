using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class MissionsController : Controller
    {
        // GET: Missions
        
      
        public ActionResult Mission(string mission)
        {
            return View();
        }
       
        public ActionResult _____MissionFAQ(string mission)
        {
            
            switch(mission)
            {
                case "cdn":
                    @ViewBag.missionName = "Calorado Denver North Mission";
                    @ViewBag.missionPresident = "Brent M. Mendenhall";
                    @ViewBag.missionAddress = "Colorado Denver North Mission";
                    @ViewBag.missionStreet = "1250 Main St.";
                    @ViewBag.missionStateCityZip = "Broomfield, CO 80020";
                    @ViewBag.missionCountry="United States";
                    @ViewBag.missionLanguages="English, Spanish";
                    @ViewBag.missionClimate="semi-arid with precipitation gradually increasing as you go eastward into Kansas and Nebraska.";
                    @ViewBag.missionDominateReligion ="Catholic";
                    @ViewBag.missionSymbol="../Content/imgs/coloradoMissionSymbol.jpg";
                    break;
                case "gc":
                    @ViewBag.MissionName = "Guatemala Cobán Mission";
                    @ViewBag.MissionPresident = "John F. Curtiss";
                    @ViewBag.missionAddress = "Misión Guatemala Cobán";
                    @ViewBag.missionStreet = "6ta Avenida, 2-36, Zona 1";
                    @ViewBag.missionStateCityZip = "Cobán";
                    @ViewBag.missionCountry="Guatemala";
                    @ViewBag.missionLanguages="Spanish";
                    @ViewBag.missionClimate="Tropical or Temperate depending on the area you are in. Guatemala has rainy and dry seasons.";
                    @ViewBag.missionDominateReligion ="Catholic";
                    @ViewBag.missionSymbol="../Content/imgs/guatemalaMissionSymbol.jpg";
                    break;
                case "jt":
                    @ViewBag.MissionName = "Japan Tokyo South Mission";
                    @ViewBag.MissionPresident = "Takashi Wada";
                    @ViewBag.missionAddress = "apan Tokyo South Mission";
                    @ViewBag.missionStreet = "1-7-7 Kichijoji Higashi-cho";
                    @ViewBag.missionStateCityZip = "Musashino-shi, Tokyo 180-0002";
                    @ViewBag.missionCountry="Japan";
                    @ViewBag.missionLanguages = "Japanese";
                    @ViewBag.missionClimate = "Temperate";
                    @ViewBag.missionDominateReligion = "Shinto and Buddhism";
                    @ViewBag.missionSymbol="../Content/imgs/japanMissionSymbol.jpg";
                    break;

            }
            return View();
        }
    }
}