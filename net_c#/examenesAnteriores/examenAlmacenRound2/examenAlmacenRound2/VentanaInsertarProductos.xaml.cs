using examenAlmacenRound2.dto;
using examenAlmacenRound2.logica;
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
using System.Windows.Shapes;

namespace examenAlmacenRound2
{
    /// <summary>
    /// Lógica de interacción para VentanaInsertarProductos.xaml
    /// </summary>
    public partial class VentanaInsertarProductos : Window
    {
        private LogicaNegocio logica;

        public VentanaInsertarProductos(LogicaNegocio logica)
        {
            InitializeComponent();
            this.logica = logica;
        }
    }
}
