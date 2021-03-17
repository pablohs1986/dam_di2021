using examenAlmacenRound2.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenAlmacenRound2.logica
{
    public class LogicaNegocio
    {
        public ObservableCollection<ProductoDTO> listaProductos { get; set; }

        public LogicaNegocio()
        {
            this.listaProductos = new ObservableCollection<ProductoDTO>();
            this.listaProductos.Add(new ProductoDTO("1", "1", 1));
        }

        public void insertarProducto(ProductoDTO producto)
        {
            this.listaProductos.Add(producto);
        }
    }
}
