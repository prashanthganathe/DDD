using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Extensions
{
    public static class DateTimeExtension
    {
        public static DateTime RoundUp(this DateTime dt, TimeSpan d)
        {
            return new DateTime(((dt.Ticks + d.Ticks - 1) / d.Ticks) * d.Ticks);
        }

        public static DateTime GetUserLocalTime(this DateTime utcTime,int offset)
        {           
                DateTime usertime;
                usertime = utcTime.AddMinutes(-1 * offset);
                return usertime;
        }

        public static DateTime GetUtcUserTime(this DateTime localServerTime,int offset)
        {                      
                DateTime usertime;
                usertime = localServerTime.AddMinutes(Convert.ToInt32(offset));
                return usertime;         
        }


    }
}
