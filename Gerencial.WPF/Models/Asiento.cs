using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Gerencial.WPF.Models
{
    public class Asiento
    {
        private double totalDebe;

        public double TotalDebe
        {
            get 
            { 
                return totalDebe; 
            }
            set 
            { 
                totalDebe = value; 
            }
        }
        private double totalHaber;

        public double TotalHaber
        {
            get 
            { 

                return totalHaber; 
            }
            set { totalHaber = value; }
        }
        


        private int numero;

        public int Numero
        {
            get 
            { 
                return numero; 
            }
            set { numero = value; }
        }


        private DateTime fecha;

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }


        
        private ObservableCollection<Transaccion> transacciones;
        public ObservableCollection<Transaccion> Transacciones
        {
            get
            {
                if (transacciones == null)
                    transacciones = new ObservableCollection<Transaccion>();
                return transacciones;
            }
            set
            {
                transacciones = value;
            }
        }
        public string Glosa { get; set; }
    }
}
