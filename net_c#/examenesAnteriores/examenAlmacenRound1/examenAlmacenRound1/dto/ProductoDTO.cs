using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenAlmacenRound1.dto
{
    public class ProductoDTO: INotifyPropertyChanged, IDataErrorInfo, ICloneable
    {
        private string _producto;
        private string _categoria;
        private int _stock;

        public ProductoDTO()
        {
            this._stock = 0;
        }

        public ProductoDTO(string producto, string categoria, int stock)
        {
            _producto = producto;
            _categoria = categoria;
            _stock = stock;
        }

        public string this[string columnName]
        {
            get
            {
                String result = "";
                if (columnName == "Producto")
                    if (string.IsNullOrEmpty(Producto))
                        result = "Debe introducir un producto";
                if (columnName == "Categoria")
                    if (string.IsNullOrEmpty(Categoria))
                        result = "Debe introducir un categoría";
                return result;
            }
        }

        public string Producto
        {
            get { return _producto; }
            set
            {
                this._producto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Producto"));
            }
        }

        public string Categoria
        {
            get { return _categoria; }
            set
            {
                this._categoria = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Categoría"));
            }
        }

        public int Stock
        {
            get { return _stock; }
            set
            {
                this._stock = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Stock"));

            }
        }

        public string Error
        {
            get
            {
                return "";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Producto;
        }
    }
}
