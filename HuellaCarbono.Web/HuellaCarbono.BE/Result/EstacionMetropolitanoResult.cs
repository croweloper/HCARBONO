using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellaCarbono.BE.Result
{
    public class EstacionMetropolitanoResult
    {
        public bool result { get; set; }
        public List<EstacionMetropolitanoBE> data { get; set; }
    }
}
