
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.dto;

namespace Examen2aEval2020.logica
{
    public class Logica
    {
        public ObservableCollection<Persona> ListaPersonas { get; set; }


        public Logica()
        {
            ListaPersonas = new ObservableCollection<Persona>();
        }

        public void InsertarPersona(Persona persona)
        {
            ListaPersonas.Add(persona);
        }

        public void ModificarEstadoEntra(int posicion)      //Método para modificar la propiedad estado según la posición de la lista
        {            
            ListaPersonas[posicion].Estado = "Dentro";

        }

        public void ModificarEstadoSale(int posicion)       //Lo mismo pero para salir
        {
            ListaPersonas[posicion].Estado = "Fuera";

        }
    }
}
