using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAppFinalRound2.dto;

namespace VideoAppFinalRound2.logica
{
    public class Logica
    {
        public ObservableCollection<Libro> listaLibros { get; set; }

        public Logica()
        {
            listaLibros = new ObservableCollection<Libro>();
        }

        public void aniadirLibro(Libro libro)
        {
            listaLibros.Add(libro);
        }

        public void modificarLibro(Libro libro, int posicion)
        {
            listaLibros[posicion] = libro; 
        }
    }
}
