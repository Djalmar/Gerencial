using FirstFloor.ModernUI.Windows.Controls;
using Gerencial.WPF.Models;
using Gerencial.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gerencial.WPF.Views
{
    /// <summary>
    /// Interaction logic for TransaccionView.xaml
    /// </summary>
    public partial class TransaccionView : UserControl
    {
        ModernWindow window;
        PlanCuentasViewModel viewModel;
        LibroDiarioViewModel libroViewModel;
        public TransaccionView()
        {
            InitializeComponent();
            transaccion = new Transaccion();
            DataContext = viewModel = new PlanCuentasViewModel();
            libroViewModel = new LibroDiarioViewModel();
        }
        public TransaccionView(ModernWindow window)
        {
            InitializeComponent();
            transaccion = new Transaccion();
            DataContext = viewModel = new PlanCuentasViewModel();
            libroViewModel = new LibroDiarioViewModel();
            this.window = window;   
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            window.Close();
        }
        Transaccion transaccion;
        private void Aceptar(object sender, RoutedEventArgs e)
        {
            if (getData())
            {
                libroViewModel.Asiento.Transacciones.Add(transaccion);
            }
            else
                new ModernDialog { Title = "Alerta", Content = "Los datos no son correctos" }.Show();
            window.Close();
        }

        private bool getData()
        {
            double debe;
            double haber;
            if(cmbCuenta.SelectedItem!=null)
            {
                transaccion.Cuenta = cmbCuenta.SelectedItem as Cuenta;
                if( double.TryParse(txtDebe.Text,out debe))
                {
                    transaccion.Debe = debe;
                    transaccion.Haber = 0;
                    return true;
                }
                if (double.TryParse(txtHaber.Text, out haber))
                {
                    transaccion.Debe = 0;
                    transaccion.Haber = haber;
                    return true;
                }
            }
            return true;
        }
    }
}
