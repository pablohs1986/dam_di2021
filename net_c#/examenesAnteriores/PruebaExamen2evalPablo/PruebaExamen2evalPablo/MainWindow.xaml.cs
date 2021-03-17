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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PruebaExamen2evalPablo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Logica logica;

        public MainWindow()
        {
            InitializeComponent();
            logica = new Logica();
            dgDatos.DataContext = logica; 
            cbSelector.DataContext = logica;
        }

        private void menuAñadir_Click(object sender, RoutedEventArgs e)
        {
            DialogoAlta dialogoAlta = new DialogoAlta(logica);
            dialogoAlta.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dgDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbSelector.DataContext = logica;

            Persona personaSeleccionada = (Persona)cbSelector.SelectedItem;

            if (personaSeleccionada.Estado == "Fuera")
            {
                btnEntra.IsEnabled = true;
                btnSale.IsEnabled = false;
            } else
            {
                btnEntra.IsEnabled = false;
                btnSale.IsEnabled = true;
            }
        }

        private void btnEntra_Click(object sender, RoutedEventArgs e)
        {
            int posicionPersona = cbSelector.SelectedIndex;

            if(posicionPersona >= 0)
            {
                cbSelector.DataContext = logica;
                logica.modificarEstadoEntra(posicionPersona);
                btnEntra.IsEnabled = false;
                btnSale.IsEnabled = true;
            } else
            {
                MessageBox.Show("Seleccione un elemento del ComboBox");
            }
        }

        private void btnSale_Click(object sender, RoutedEventArgs e)
        {
            int posicionPersona = cbSelector.SelectedIndex;

            if (posicionPersona >= 0)
            {
                cbSelector.DataContext = logica;
                logica.modificarEstadoSale(posicionPersona);
                btnEntra.IsEnabled = true;
                btnSale.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione un elemento del ComboBox");
            }
        }
    }
}
 