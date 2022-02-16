using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellaCarbono.BE
{
    public class Huella_ListaBE
    {
        public int ID_LISTA { get; set; }
        public int ID_TIPO_DESCRIP { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal LATITUD { get; set; }
        public decimal LONGITUD { get; set; }
}
}
