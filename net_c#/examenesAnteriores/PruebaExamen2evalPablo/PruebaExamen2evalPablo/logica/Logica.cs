using PruebaExamen2evalPablo.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamen2evalPablo.logica
{
    public class Logica
    {
        public ObservableCollection<Persona> ListaPersonas { get; set; }

        public Logica()
        {
            ListaPersonas = new ObservableCollection<Persona>();
        }

        public void insertarPersona(Persona persona)
        {
            ListaPersonas.Add(persona);
        }

        public void modificarEstadoEntra(int posicion)
        {
            ListaPersonas[posicion].Estado = "Dentro";
        }

        public void modificarEstadoSale(int posicion)
        {
            ListaPersonas[posicion].Estado = "Fuera";
        }
    }
}
