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
using VideoAppFinalRound2.dto;
using VideoAppFinalRound2.logica;

namespace VideoAppFinalRound2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Logica logica;
        public MainWindow()
        {
            InitializeComponent();
            logica = new Logica();
            dgLibros.DataContext = logica;
        }

        private void miAñadir_Click(object sender, RoutedEventArgs e)
        {
            DialogoAltaLibro dialogoLibro = new DialogoAltaLibro(logica);
            dialogoLibro.Show();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if(dgLibros.SelectedIndex != -1)
            {
                Libro libro = (Libro)dgLibros.SelectedItem;
                DialogoAltaLibro dialogoAltaLibro = new DialogoAltaLibro(logica, (Libro)libro.Clone(), dgLibros.SelectedIndex);
                dialogoAltaLibro.Show();
            }
        }
    }
}
