using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamen2evalPablo.dto
{
    public class Persona : INotifyPropertyChanged, ICloneable, IDataErrorInfo
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
            Nombre = nombre;
            Apellidos = apellidos;
            Estado = estado;
        }

        

        // Estos setters para que actualice bien la tabla
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

        public string Error => " ";

        public string this[string columnName]
        {
            get
            {
                String result = "";
                if (columnName == "Nombre")
                    if (string.IsNullOrEmpty(_nombre))
                        result = "Debe introducir un título";
                if (columnName == "Apellidos")
                    if (string.IsNullOrEmpty(_apellidos))
                        result = "Debe introducir un autor";
                return result;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            return Nombre + " " + Apellidos;
        }
    }
}
