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
using System.Windows.Shapes;

namespace examenAlmacen1
{
    /// <summary>
    /// Lógica de interacción para dialogoInsertarProductos.xaml
    /// </summary>
    public partial class dialogoInsertarProductos : Window
    {
        LogicaNegocio logica;
        ProductoDTO producto;
        int contadorErrores;

        public dialogoInsertarProductos(LogicaNegocio logica)
        {
            InitializeComponent();
            this.logica = logica;
            producto = new ProductoDTO(); // producto vacío
            this.DataContext = producto; // que es el contexto
            contadorErrores = 0;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            logica.aniadirProducto(producto); // lo añade a la lista
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
