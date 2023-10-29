using Layer3Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBase.Model
{
    public class Statistic
    {
        private int _accessCount { get; set; }


        public static void WebsiteVisit()
        {
            DBObjects.AddVisit();
        }


    }
}
