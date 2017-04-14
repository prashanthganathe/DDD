using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infra.Data
{
   public class SortAndPageCriteria
    {
        public string SortDirection { get; set; } = "DESC";
        public string SortBy { get; set; }
    }
}
