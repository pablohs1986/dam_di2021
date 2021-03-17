using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video6_dataGrid.dto
{
    public class Persona : INotifyPropertyChanged // Interfaz para implementar cambios en la tabla al añadir a la lista
    {
        String nombre;
        String apellidos;

        public String Nombre
        {
            get { return nombre; }
            set
            {
                this.nombre = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
            }
        }
        public string Apellidos { get => apellidos; set => apellidos = value; }

        public Persona(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }

        public override string ToString()
        {
            return nombre + " " + apellidos;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
