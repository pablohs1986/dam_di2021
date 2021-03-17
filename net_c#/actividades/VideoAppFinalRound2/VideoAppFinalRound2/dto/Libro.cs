using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoAppFinalRound2.dto
{
    public class Libro: INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private string _titulo;
        private string _autor;
        private DateTime _fechaEntrada;

        public Libro()
        {
            this._fechaEntrada = DateTime.Now;
        }

        public Libro(string titulo, string autor, DateTime fechaEntrada)
        {
            _titulo = titulo;
            _autor = autor;
            _fechaEntrada = fechaEntrada;
        }

        public string this[string columnName]
        {
            get
            {
                String result = "";
                if (columnName == "Título")
                    if (string.IsNullOrEmpty(_titulo))
                        result = "Debe introducir un título";
                if (columnName == "Autor")
                    if (string.IsNullOrEmpty(_autor))
                        result = "Debe introducir un autor";
                return result;
            }
        }

        public string Titulo
        {
            get { return _titulo; }
            set
            {
                this._titulo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Titulo"));

            }
        }

        public string Autor
        {
            get { return _autor; }
            set
            {
                this._autor = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Autor"));

            }
        }

        public DateTime FechaEntrada
        {
            get { return _fechaEntrada; }
            set
            {
                this._fechaEntrada = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Fecha entrada "));

            }
        }

        public string Error => "";

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
