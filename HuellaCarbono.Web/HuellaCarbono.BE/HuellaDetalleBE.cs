using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellaCarbono.BE
{
    public class HuellaDetalleBE
    {
        public int ID_HUELLA_GENERAL { get; set; }
        public int ID_DETALLE_HUELLA { get; set; }
        public Nullable<int> ID_TIPO_TRANSP { get; set; }
        public Nullable<int> ID_TIPO_VEHI { get; set; }
        public string TIEMPO_HRS_MIN { get; set; }
        public Nullable<decimal> COSTO { get; set; }
        public string ORIGEN_LAT { get; set; }
        public string ORIGEN_LONG { get; set; }
        public string DESTINO_LAT { get; set; }
        public string DESTINO_LONG { get; set; }
        public Nullable<int> ORDEN { get; set; }
        public Nullable<int> ID_TIPO_COMB { get; set; }
        public Nullable<decimal> COSTO_COMB { get; set; }
        public Nullable<bool> FLAG_NOSE_COMB { get; set; }
        public Nullable<decimal> POTENCIA_ELECT { get; set; }
        public Nullable<bool> FLAG_NOSE_POTE { get; set; }
        public Nullable<int> ID_TIPO_POTE { get; set; }
        public Nullable<int> ID_TIPO_DESCR { get; set; }
        public string DESCRIP_INICIO { get; set; }
        public string DESCRIP_FIN { get; set; }
    }
}
