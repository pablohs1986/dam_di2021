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
using VideosAppFinal.dto;
using VideosAppFinal.logica;

namespace VideosAppFinal
{
    /// <summary>
    /// Lógica de interacción para DialogoLibro.xaml
    /// </summary>
    public partial class DialogoLibro : Window
    {
        private LogicaNegocio logica;
        private Libro nuevoLibro;
        private int posicion;
        private Boolean isModificando;
        private int contadorErrores;

        public DialogoLibro(LogicaNegocio logica)
        {
            InitializeComponent();
            this.logica = logica;
            nuevoLibro = new Libro();
            this.DataContext = nuevoLibro;
            isModificando = false;
        }

        public DialogoLibro(LogicaNegocio logica, Libro libroAModificar, int posicion)
        {
            InitializeComponent();
            this.logica = logica;
            nuevoLibro = libroAModificar;
            this.posicion = posicion;
            this.DataContext = nuevoLibro;
            isModificando = true;
        }

        private void buttonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (isModificando)
            {
                logica.modificarLibro(nuevoLibro, posicion);
                this.Close();
            } else
            {
                logica.aniadirLibro(nuevoLibro);
                this.Close();
            }
        }

        private void validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                contadorErrores++;
            } else
            {
                contadorErrores--;
            }

            if(contadorErrores == 0)
            {
                buttonAceptar.IsEnabled = true;
            } else
            {
                buttonAceptar.IsEnabled = false;
            }
        }

        private void textBoxTitulo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
