using FirstFloor.ModernUI.Windows.Controls;
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
    /// Interaction logic for LibroDiario.xaml
    /// </summary>
    public partial class LibroDiario : UserControl
    {
        LibroDiarioViewModel viewModel;
        public LibroDiario()
        {
            InitializeComponent();
            this.DataContext = viewModel = new LibroDiarioViewModel();
        }

        private void NuevoAsiento(object sender, RoutedEventArgs e)
        {
            viewModel.Asiento = null;
            ModernWindow window = new ModernWindow() { Style = (Style)App.Current.Resources["EmptyWindow"] };
            window.Title = "Asiento";
            window.IsTitleVisible=true;
            AsientoView cuentaView = new AsientoView(window);
            window.Content = cuentaView;
            window.Width = 480;
            window.Height = 250;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }
    }
}
