using examenAlmacen1.dto;
using examenAlmacen1.logica;
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

namespace examenAlmacen1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LogicaNegocio logica;
        public MainWindow()
        {
            InitializeComponent();
            logica = new LogicaNegocio();
            dgProductos.DataContext = logica;
            cbProductos.DataContext = logica;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductoDTO producto = (ProductoDTO)cbProductos.SelectedItem;
            this.refresh(producto);
        }

        private void btnEntra_Click(object sender, RoutedEventArgs e)
        {
            ProductoDTO producto = (ProductoDTO)cbProductos.SelectedItem;
            producto.Stock++;
            this.refresh(producto);
        }

        private void btnSale_Click(object sender, RoutedEventArgs e)
        {
            ProductoDTO producto = (ProductoDTO)cbProductos.SelectedItem;
            producto.Stock--;
            this.refresh(producto);
        }

        private void refresh(ProductoDTO producto)
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

        private void miMenu_Click(object sender, RoutedEventArgs e)
        {
            dialogoInsertarProductos dialogoInsertar = new dialogoInsertarProductos(logica);
            dialogoInsertar.Show();
        }
    }
}
