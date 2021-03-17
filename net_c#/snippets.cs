// DTO
public string Producto
        {
            get { return _producto; }
            set
            {
                this._producto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Producto"));
            }
        }

// SUMAR Y REFRESCAR
private void btnEntra_Click(object sender, RoutedEventArgs e)
        {
            ProductoDTO producto = (ProductoDTO)cbProductos.SelectedItem;
            producto.Stock++;
            this.refresh(producto);
        }

private void btnSale_Click(object sender, RoutedEventArgs e)
{
    ProductoDTO producto = (ProductoDTO)cbProductos.SelectedItem;
    producto.Stock--;
    this.refresh(producto);
}

private void refresh(ProductoDTO producto)
{
    if (producto.Stock > 0)
    {
        btnSale.Visibility = Visibility.Visible;
        btnEntra.Visibility = Visibility.Visible;
    }
    else
    {
        btnSale.Visibility = Visibility.Hidden;
        btnEntra.Visibility = Visibility.Visible;
    }
}

private void miMenu_Click(object sender, RoutedEventArgs e)
{
    dialogoInsertarProductos dialogoInsertar = new dialogoInsertarProductos(logica);
    dialogoInsertar.Show();
}


// VALIDACIÓN
public string this[string columnName]
    {
        get
        {
            String result = "";
            if (columnName == "Producto")
                if (string.IsNullOrEmpty(producto))
                    result = "Debe introducir un producto";
            if (columnName == "Categoria")
                if (string.IsNullOrEmpty(categoria))
                    result = "Debe introducir un categoría";
            return result;
        }
    }

public string Error
        {
            get
            {
                return "";
            }
        }

private void validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                contadorErrores++;
            }
            else
            {
                contadorErrores--;
            }

            if (contadorErrores == 0)
            {
                btnInsertar.IsEnabled = true;
            }
            else
            {
                btnInsertar.IsEnabled = false;
            }
        }

