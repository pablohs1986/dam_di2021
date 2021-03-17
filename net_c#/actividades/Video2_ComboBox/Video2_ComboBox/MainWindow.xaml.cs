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
using Video2_ComboBox.dto;

namespace Video2_ComboBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Persona> listaPersonas = new List<Persona>();
            listaPersonas.Add(new Persona("Pepe", "García"));
            listaPersonas.Add(new Persona("María", "Sánchez"));

            foreach (var persona in listaPersonas)
            {
                ComboBoxItem cbi = new ComboBoxItem();
                cbi.Content = persona;
                cbPersonas.Items.Add(cbi); // Entra
            }
        }

        private void cbPersonas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)cbPersonas.SelectedItem; // Sale
            Persona personaSeleccionada = (Persona)cbi.Content;

            labelNombre.Content = personaSeleccionada.Nombre;
            labelApellidos.Content = personaSeleccionada.Apellidos;
        }
    }
}
