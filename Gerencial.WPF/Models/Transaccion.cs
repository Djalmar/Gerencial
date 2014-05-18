using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gerencial.WPF.Models
{
    public class Transaccion
    {
        public Cuenta Cuenta { get; set; }
        public double Debe { get; set; }
        public Double Haber { get; set; }
    }
}
