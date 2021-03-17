using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenAlmacen1.dto
{
    public class ProductoDTO: INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private string producto;
        private string categoria;
        private int stock;

        public ProductoDTO()
        {
            this.stock = 0;
        }

        public ProductoDTO(string producto, string categoria, int stock)
        {
            this.producto = producto;
            this.categoria = categoria;
            this.stock = stock;
        }

      

        public string Producto
        {
            get { return producto; }
            set
            {
                this.producto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Producto"));

            }
        }
        public string Categoria
        {
            get { return categoria; }
            set
            {
                this.categoria = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Categoría"));

            }
        }

        public int Stock
        {
            get { return stock; }
            set
            {
                this.stock = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Stock"));

            }
        }

        public string this[string columnName]
        {
            get
            {
                String result = "";
                if (columnName == "Producto")
                    if (string.IsNullOrEmpty(producto))
                        result = "Debe introducir un producto";
                if (columnName == "Categoría")
                    if (string.IsNullOrEmpty(categoria))
                        result = "Debe introducir un categoría";
                return result;
            }
        }

        public string Error => "";

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return producto;
        }

    }
}
