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
    /// Interaction logic for AsientoView.xaml
    /// </summary>
    public partial class AsientoView : UserControl
    {
        ModernWindow window;
        LibroDiarioViewModel viewModel;
        public AsientoView()
        {
            InitializeComponent();
            DataContext = viewModel = new LibroDiarioViewModel();

        }
        public AsientoView(ModernWindow window)
        {
            this.window = window;
            InitializeComponent();
            DataContext = viewModel = new LibroDiarioViewModel();
        }

        private void NuevaTransaccion(object sender, RoutedEventArgs e)
        {
            ModernWindow window = new ModernWindow() { Style = (Style)App.Current.Resources["EmptyWindow"] };
            window.Title = "Transaccion";
            window.IsTitleVisible = true;
            TransaccionView cuentaView = new TransaccionView(window);
            window.Content = cuentaView;
            window.Width = 480;
            window.Height = 250;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }

        private void Aceptar(object sender, RoutedEventArgs e)
        {
            if (date.SelectedDate.HasValue)
            {
                viewModel.Asiento.Fecha = date.SelectedDate.Value;
                if (viewModel.Asiento.Transacciones.Count > 0)
                {
                    viewModel.Asientos.Add(viewModel.Asiento);
                    viewModel.Asiento.Numero = viewModel.Asientos.Count;
                    window.Close();
                }
                else
                    new ModernDialog { Title = "Alerta", Content = "Debe agregar alguna transaccion" }.Show();
            }
            else
            {
                new ModernDialog { Title = "Alerta", Content = "Debe seleccionar una fecha" }.Show();
            }
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            window.Close();
        }

    }
}
