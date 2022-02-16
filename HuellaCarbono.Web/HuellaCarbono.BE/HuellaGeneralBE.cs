using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellaCarbono.BE
{
    public class HuellaGeneralBE
    {
        public string ID_USUARIO { get; set; }
        public int ID_AGENCIA { get; set; }
        public bool flagHome { get; set; }

        public bool flagPresencial { get; set; }
        public List<HuellaDetalleBE> Detalle { get; set; }
    }
}
