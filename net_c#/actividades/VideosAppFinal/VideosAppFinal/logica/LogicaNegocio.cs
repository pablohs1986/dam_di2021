using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideosAppFinal.dto;

namespace VideosAppFinal.logica
{
    public class LogicaNegocio
    {
        public ObservableCollection<Libro> listaLibros { get; set; }

        public LogicaNegocio()
        {
            this.listaLibros = new ObservableCollection<Libro>();
            listaLibros.Add(new Libro("título", "pepín", DateTime.Now));
        }

        public void aniadirLibro(Libro libro)
        {
            this.listaLibros.Add(libro);
        }

        public void modificarLibro(Libro libro, int posicion)
        {
            listaLibros[posicion] = libro;
        }
    }
}
