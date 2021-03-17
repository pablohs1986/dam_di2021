using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenAlmacenRound2.dto
{
    public class ProductoDTO: INotifyPropertyChanged
    {
        string _producto;
        string _categoria;
        int _stock;

        public ProductoDTO()
        {
        }

        public ProductoDTO(string producto, string categoria, int stock)
        {
            _producto = producto;
            _categoria = categoria;
            _stock = stock;
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

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
