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
using VideoAppFinalRound2.dto;
using VideoAppFinalRound2.logica;

namespace VideoAppFinalRound2
{
    /// <summary>
    /// Lógica de interacción para DialogoAltaLibro.xaml
    /// </summary>
    public partial class DialogoAltaLibro : Window
    {
        private Logica logica;
        public Libro libro;
        private int posicion;
        private Boolean modificar;
        private int contadorErrores;

        public DialogoAltaLibro(Logica logica)
        {
            InitializeComponent();
            this.logica = logica;
            this.libro = new Libro();
            this.DataContext = libro;
            modificar = false;
        }

        public DialogoAltaLibro(Logica logica, Libro libroModificar, int posicion)
        {
            InitializeComponent();
            this.logica = logica;
            this.libro = libroModificar;
            this.posicion = posicion;
            this.DataContext = libro;
            modificar = true;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if(modificar)
            {
                logica.modificarLibro(libro, posicion);
            }
            else
            {
                this.Close();
            }
            
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
                btnAceptar.IsEnabled = true;
            }
            else
            {
                btnCancelar.IsEnabled = false;
            }
        }
    }
}
