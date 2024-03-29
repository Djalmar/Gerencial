﻿using Gerencial.WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Gerencial.WPF.ViewModels
{
    public class PlanCuentasViewModel
    {	
        public ObservableCollection<Cuenta> Cuentas
        {
            get
            {
                if (Data.Cuentas == null)
                    Data.Cuentas = new ObservableCollection<Cuenta>();
                return Data.Cuentas;
            }
            set
            {
                Data.Cuentas = value;
            }
        }
        public PlanCuentasViewModel()
        {
            if (Cuentas.Count == 0)
            {
                Cuentas.Add(new Cuenta() { Nombre = "Activos", Codigo = 1 });
                Cuentas.Add(new Cuenta() { Nombre = "Pasivos", Codigo = 2 });
                Cuentas.Add(new Cuenta() { Nombre = "Ventas", Codigo = 3 });
                Cuentas.Add(new Cuenta() { Nombre = "Gastos", Codigo = 4 });
            }
        }

    }
}
