using examenAlmacenRound1.dto;
using examenAlmacenRound1.logica;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace examenAlmacenRound1
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
            cbDatos.DataContext = logica;
        }

        private void miInsertar_Click(object sender, RoutedEventArgs e)
        {
            VentanaInsertarProductos ventanaInsertar = new VentanaInsertarProductos(logica);
            ventanaInsertar.Show();
        }

        private void btnEntra_Click(object sender, RoutedEventArgs e)
        {
            ProductoDTO productoSeleccionado = (ProductoDTO) cbDatos.SelectedItem;
            productoSeleccionado.Stock++;
            this.refrescar(productoSeleccionado);
        }

        private void btnSale_Click(object sender, RoutedEventArgs e)
        {
            ProductoDTO productoSeleccionado = (ProductoDTO)cbDatos.SelectedItem;
            productoSeleccionado.Stock--;
            this.refrescar(productoSeleccionado);
        }

        private void cbDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductoDTO productoSeleccionado = (ProductoDTO)cbDatos.SelectedItem;
            this.refrescar(productoSeleccionado);
        }

        // Refresca la tabla 
        private void refrescar(ProductoDTO producto)
        {
            if (producto.Stock > 0)
            {
                btnSale.Visibility = Visibility.Visible;
                btnEntra.Visibility = Visibility.Visible;
            }
            else
            {
                btnSale.Visibility = Visibility.Hidden;
                btnEntra.Visibility = Visibility.Visible;
            }
        }

       
    }
}
