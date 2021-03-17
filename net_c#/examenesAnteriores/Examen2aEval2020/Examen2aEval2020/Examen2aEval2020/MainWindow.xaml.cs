using Examen2aEval2020.logica;
using Prueba.dto;
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

namespace Examen2aEval2020
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
            dgPersonas.DataContext = logica;          //contexto binding del datagrid
            cbListaPersonas.DataContext = logica;    //contexto binding del combo

        }


        private void itemAdd_Click(object sender, RoutedEventArgs e)
        {
            VentanaAltaPersonas ventanaAltaPersonas = new VentanaAltaPersonas(logica);
            ventanaAltaPersonas.Show();
        }

        private void btEntra_Click(object sender, RoutedEventArgs e)
        {
            int posicion = cbListaPersonas.SelectedIndex;   //recoge la posición del elemento en la lista

            if (posicion >= 0)                              //lógica para evitar desastres
            {
                cbListaPersonas.DataContext = logica;       //contexto del binding aquí
                logica.ModificarEstadoEntra(posicion);      //llamamos al método modificar en la lista según la posición
                btEntra.IsEnabled = false;
                btSale.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione un elemento del ComboBox");
            }

        }

        private void btSale_Click(object sender, RoutedEventArgs e)     //Igual al anterior
        {
            int posicion = cbListaPersonas.SelectedIndex;

            if (posicion >= 0)
            {
                cbListaPersonas.DataContext = logica;
                logica.ModificarEstadoSale(posicion);
                btEntra.IsEnabled = true;
                btSale.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione un elemento del ComboBox");
            }
        }

        private void cbListaPersonas_SelectionChanged(object sender, SelectionChangedEventArgs e)   //Método para habilitar/deshabilitar los botones
        {
            cbListaPersonas.DataContext = logica;

            Persona seleccionada = (Persona)cbListaPersonas.SelectedItem; //objeto persona seleccionada asignada al objeto que devuelve el Combo en la selección
            if (seleccionada.Estado== "Fuera")
            {
                btEntra.IsEnabled = true;
                btSale.IsEnabled = false;
            }
            else
            {
                btEntra.IsEnabled = false;
                btSale.IsEnabled = true;
            }
  
        }
    }
}
