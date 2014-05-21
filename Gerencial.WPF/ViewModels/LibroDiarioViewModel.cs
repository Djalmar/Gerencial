using Gerencial.WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Gerencial.WPF.ViewModels
{
    public class LibroDiarioViewModel
    {
        public ObservableCollection<Asiento> Asientos
        {
            get 
            {
                if (Data.Asientos == null)
                    Data.Asientos = new ObservableCollection<Asiento>();
                return Data.Asientos;
            }
            set { Data.Asientos = value; }
        }
        

        public Asiento Asiento
        {
            get 
            {
                if (Data.AsientoActual == null)
                    Data.AsientoActual = new Asiento();
                return Data.AsientoActual; 
            }
            set { Data.AsientoActual = value; }
        }
        

    }
}
