using Examen2aEval2020.logica;
using Prueba.dto;
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

namespace Examen2aEval2020
{
    /// <summary>
    /// Lógica de interacción para VentanaAltaPersonas.xaml
    /// </summary>
    public partial class VentanaAltaPersonas : Window
    {
        private Logica logica;
        private Persona persona;


        public VentanaAltaPersonas(Logica logica) //creamos el contexto del diálogo
        {
            InitializeComponent();                  //iniciamos diálogo
            btInsertar.IsEnabled = false;           //desactivamos el botón por defecto
            this.logica = logica;                   //relacionamos lógica a este contexto
            persona = new Persona();                //instanciamos objeto vacío 
            this.DataContext = persona;             //asociamos contexto del binding
        }

        private void tbCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btInsertar_Click(object sender, RoutedEventArgs e)
        {
            if ((tbNombre.Text != "") && (tbApellido.Text != ""))
            {
                btInsertar.IsEnabled = true;
                logica.InsertarPersona(persona);
                tbNombre.Clear();               //campo Nombre a vacío
                tbApellido.Clear();             //campo Apellido a vacío
                persona = new Persona();        //instancia de nuevo objeto persona
                this.DataContext = persona;     //establecer el contexto del binding ahora aquí
            }
            else
            {
                MessageBox.Show("Introduzca valores en los campos correspondientes");
            }


        }

        private void tbNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            btInsertar.IsEnabled = !string.IsNullOrEmpty(tbNombre.Text);        //Se enciende el botón cuando el string es distinto de vacío/null
        }
    }
}
