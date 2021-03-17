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
using VideosAppFinal.dto;
using VideosAppFinal.logica;

namespace VideosAppFinal
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogicaNegocio logica;

        public MainWindow()
        {
            InitializeComponent();
            logica = new LogicaNegocio();
            dataGridLibros.DataContext = logica;
        }

        private void menuItemNuevo_Click(object sender, RoutedEventArgs e)
        {
            DialogoLibro dialogoLibro = new DialogoLibro(logica);
            dialogoLibro.Show();
        }

        private void buttonModificar_Click(object sender, RoutedEventArgs e)
        {
            if(dataGridLibros.SelectedIndex != -1) {
                Libro libro = (Libro)dataGridLibros.SelectedItem;
                DialogoLibro dialogoLibro = new DialogoLibro(logica, (Libro)libro.Clone(), dataGridLibros.SelectedIndex); // El clone se castea porque devuelve un object, no un libro.
                dialogoLibro.Show();
            }
        }

        private void menuItemArchivo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
