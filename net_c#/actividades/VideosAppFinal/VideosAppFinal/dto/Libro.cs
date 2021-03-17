using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideosAppFinal.dto
{
    public class Libro : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        String titulo;
        String autor;
        DateTime fechaEntrada;

        public Libro(string titulo, string autor, DateTime fechaEntrada)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fechaEntrada = fechaEntrada;
        }

        public Libro()
        {
            this.fechaEntrada = DateTime.Now;
        }

        public string Titulo {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Titulo"));
            }
        }

        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Autor"));
            }
        }

        public DateTime FechaEntrada
        {
            get
            {
                return fechaEntrada;
            }
            set
            {
                fechaEntrada = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("FechaEntrada"));
            }
        }

        public string Error => " ";

        public string this[string columnName]
        {
            get
            {
                string resultado = "";
                if (columnName == "Titulo")
                {
                    if(string.IsNullOrEmpty(titulo))
                    {
                        resultado = "Debe introducir el título.";
                    }
                } else if (columnName == "Autor")
                {
                    if (string.IsNullOrEmpty(autor)) {
                        resultado = "Debe introducir el autor.";
                    }
                }
                return resultado; // si retorna vacío, no hay error.
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            return this.MemberwiseClone(); // clona el objeto, una copia exacta en un objeto diferente.
        }
    }
}
