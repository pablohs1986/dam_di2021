using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video5_bindingComboBox.dto
{
    public class Persona
    {
        String nombre;
        String apellidos;

        public string Nombre { get => nombre; set => nombre = value; }
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
    }
}
