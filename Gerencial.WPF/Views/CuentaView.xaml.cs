using FirstFloor.ModernUI.Windows.Controls;
using Gerencial.WPF.Models;
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
    /// Interaction logic for CuentaView.xaml
    /// </summary>
    public partial class CuentaView : UserControl
    {
        Cuenta cuenta;  
        ModernWindow container;
        public CuentaView()
        {
            InitializeComponent();
            this.Loaded += CuentaView_Loaded;
        }

        public CuentaView(FirstFloor.ModernUI.Windows.Controls.ModernWindow window)
        {
            InitializeComponent();
            this.Loaded += CuentaView_Loaded;
            this.container = window;
        }

        void CuentaView_Loaded(object sender, RoutedEventArgs e)
        {
                
        }
        /// <summary>
        /// Aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModernButton_Click(object sender, RoutedEventArgs e)
        {

            if (LoadData())
            {
                Data.Cuentas.Add(cuenta);
                container.Close();
            }
            else
                new ModernDialog
                {
                    Title = "Advertencia",
                    Content = "Debe llenar todos los campos, el codigo es un numero"
                }.Show();
        }


        private bool LoadData()
        {
            cuenta = new Cuenta();
            if (txtNombre.Text != "")
            {
                cuenta.Nombre = txtNombre.Text;
                int codigo;
                if (int.TryParse(txtCodigo.Text, out codigo))
                {
                    cuenta.Codigo = codigo;
                    return true;
                }
            }
            return false;
        }

        private void ModernButton_Click_1(object sender, RoutedEventArgs e)
        {
            container.Close();
        }
    }
}
