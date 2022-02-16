using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellaCarbono.BE.Result
{
    public class TipoCombustibleResult
    {
        public bool result { get; set; }
        public List<TipoCombustibleBE> data { get; set; }
    }
}
