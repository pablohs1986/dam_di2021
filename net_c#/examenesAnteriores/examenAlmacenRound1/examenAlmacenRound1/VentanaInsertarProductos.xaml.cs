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
using System.Windows.Shapes;

namespace examenAlmacenRound1
{
    /// <summary>
    /// Lógica de interacción para VentanaInsertarProductos.xaml
    /// </summary>
    public partial class VentanaInsertarProductos : Window
    {
        public LogicaNegocio logica;
        public ProductoDTO producto;
        private int contadorErrores;

        public VentanaInsertarProductos(LogicaNegocio logica)
        {
            InitializeComponent();
            this.logica = logica;
            this.producto = new ProductoDTO();
            this.DataContext = producto;
            this.contadorErrores = 0;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            logica.aniadirProducto(producto);
            this.Close();
        }

        private void validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                contadorErrores++;
            }
            else
            {
                contadorErrores--;
            }

            if (contadorErrores == 0)
            {
                btnInsertar.IsEnabled = true;
            }
            else
            {
                btnInsertar.IsEnabled = false;
            }
        }
    }
}
