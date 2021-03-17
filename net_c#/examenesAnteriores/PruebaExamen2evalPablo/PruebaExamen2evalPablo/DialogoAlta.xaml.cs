using PruebaExamen2evalPablo.dto;
using PruebaExamen2evalPablo.logica;
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

namespace PruebaExamen2evalPablo
{
    /// <summary>
    /// Lógica de interacción para DialogoAlta.xaml
    /// </summary>
    public partial class DialogoAlta : Window
    {

        private Logica logica;
        private Persona persona;
        private int contadorErrores;


        public DialogoAlta(Logica logica)
        {
            InitializeComponent();
            this.logica = logica;
            persona = new Persona();
            this.DataContext = persona; // contexto de este diálogo
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            logica.insertarPersona(this.persona);
            persona = new Persona();
            this.DataContext = persona;
            this.Close();
        }

        private void tbNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

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
                btnCancelar.IsEnabled = false;
            }
        }
    }
}
