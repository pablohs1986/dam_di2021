using examenAlmacenRound2.logica;
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

namespace examenAlmacenRound2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LogicaNegocio logica;

        public MainWindow()
        {
            InitializeComponent();
            this.logica = new LogicaNegocio();
            dgProductos.DataContext = logica;
            cbProductos.DataContext = logica;
        }

        private void miInsertar_Click(object sender, RoutedEventArgs e)
        {
            VentanaInsertarProductos ventanaInsertar = new VentanaInsertarProductos(this.logica);
            ventanaInsertar.Show();
        }
    }
}
