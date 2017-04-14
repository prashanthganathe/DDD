using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Extensions
{
    

    public static class IntExtension
    {
        public static decimal RoundTo(this decimal minutes, int n)
        {
            return (n * Math.Round(minutes / n));
        }
    }
}
