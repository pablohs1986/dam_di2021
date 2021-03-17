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
using Video5_bindingComboBox.dto;

namespace Video5_bindingComboBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Persona> listaPersonas { get; set; } // hacer la clase pública para que no salte incoherencia

        public MainWindow()
        {
            InitializeComponent();
            listaPersonas = new ObservableCollection<Persona>();
            listaPersonas.Add(new Persona("Pablo", "Herrero"));
            listaPersonas.Add(new Persona("Sara", "Merayo"));
            this.DataContext = this; // se indica que cuando se hace un binding se toma de referencia this.
        }

        private void buttonNuevaPersona_Click(object sender, RoutedEventArgs e)
        {
            listaPersonas.Add(new Persona("Fulanito", "García"));
        }
    }
}
