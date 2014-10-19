using SelfDestructAjax.Mockup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfDestructAjax.Mockup
{
    public static class MockCountdown

    {
        public static object MissionCountdownResponse
        {
            get
            {
                var count = new List<TimesUp>();
                count.Add(new TimesUp { Timer = 5, Destruct = "Seconds" });
                count.Add(new TimesUp { Timer = 4, Destruct = "Seconds" });
                count.Add(new TimesUp { Timer = 3, Destruct = "Seconds" });
                count.Add(new TimesUp { Timer = 2, Destruct = "Seconds" });
                count.Add(new TimesUp { Timer = 1, Destruct = "BOOM!!" });
                
                return new
               {
                   EndMessage = count
               };

            }
        }
    }
}