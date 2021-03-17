using examenAlmacen1.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenAlmacen1.logica
{
    public class LogicaNegocio
    {
        public ObservableCollection<ProductoDTO> listaProductos { get; set; }

        public LogicaNegocio()
        {
            this.listaProductos = new ObservableCollection<ProductoDTO>();
            this.listaProductos.Add(new ProductoDTO("balbal", "blabla", 10));
        }

        public void aniadirProducto(ProductoDTO producto)
        {
            listaProductos.Add(producto);
        }
    }
}
