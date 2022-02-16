using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellaCarbono.BE
{
    public class EstacionMetropolitanoBE
    {
        public int ID_ESTACION { get; set; }
        public string ESTACION { get; set; }
        public decimal? LATITUD { get; set; }
        public decimal? LONGITUD { get; set; }
    }
}
