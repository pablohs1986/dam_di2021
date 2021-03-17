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
using Video6_dataGrid.dto;

namespace Video6_dataGrid
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Persona> listaPersonas { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            listaPersonas = new ObservableCollection<Persona>();
            listaPersonas.Add(new Persona("Pablo", "Herrero"));
            listaPersonas.Add(new Persona("Sara", "Merayo"));
            this.DataContext = this;

        }

        private void buttonModificar_Click(object sender, RoutedEventArgs e)
        {
            listaPersonas.ElementAt(0).Nombre = "Yoda";
        }
    }
}
