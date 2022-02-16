using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellaCarbono.BE.Result
{
    public class EstacionTrenResult
    {
        public bool result { get; set; }
        public List<EstacionTrenBE> data { get; set; }
    }
}
