using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuellaCarbono.BE.Result
{
    public class UsuarioResult
    {
        public bool result { get; set; }
        public string message { get; set; }
        public UsuarioBE data { get; set; }
    }
}
