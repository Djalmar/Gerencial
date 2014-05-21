using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Gerencial.WPF.Models
{
    public static class Data
    {
        public static ObservableCollection<Cuenta> Cuentas { get; set; }
        public static ObservableCollection<Asiento> Asientos { get; set; }
        public static Asiento AsientoActual { get; set; }
    }
}
