using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Prueba.dto
{
    public class Persona : INotifyPropertyChanged
    {

        private string _nombre;
        private string _apellidos;
        private string _estado;

        public Persona()
        {
            this._estado = "Fuera";
        }

        public Persona(string nombre, string apellidos, string estado)
        {
            _nombre = nombre;
            _apellidos = apellidos;
            _estado = estado;
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                this._nombre = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));

            }
        }
        public string Apellidos
        {
            get { return _apellidos; }
            set
            {
                this._apellidos = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Apellidos"));

            }
        }

        public string Estado
        {
            get { return _estado; }
            set
            {
                this._estado = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Estado"));

            }
        }

        //Override del ToString para mostrar listado correctamente en ComboBox
        public override string ToString()
        {
            return Nombre+" "+Apellidos;
        }

        public event PropertyChangedEventHandler PropertyChanged;




    }
}
