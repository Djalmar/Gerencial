using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Gerencial.WPF.Models
{
    public class Asiento
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public ObservableCollection<Transaccion> Transacciones { get; set; }
        public string Descripcion { get; set; }
    }
}
