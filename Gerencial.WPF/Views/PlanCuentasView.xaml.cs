using FirstFloor.ModernUI.Windows.Controls;
using Gerencial.WPF.Models;
using Gerencial.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for PlanCuentasView.xaml
    /// </summary>
    public partial class PlanCuentasView : UserControl
    {
        PlanCuentasViewModel viewModel;
        public PlanCuentasView()
        {
            InitializeComponent();
            viewModel = new PlanCuentasViewModel();
            this.DataContext = viewModel;
            this.Loaded += PlanCuentasView_Loaded;
        }

        void PlanCuentasView_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void ModernButton_Click(object sender, RoutedEventArgs e)
        {
            ModernWindow window = new ModernWindow() { Style = (Style)App.Current.Resources["EmptyWindow"] };
            window.Title = "Cuentas";
            window.IsTitleVisible = true;
            CuentaView cuentaView = new CuentaView(window);
            window.Content = cuentaView;
            window.Width = 480;
            window.Height = 250;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }
    }
}
