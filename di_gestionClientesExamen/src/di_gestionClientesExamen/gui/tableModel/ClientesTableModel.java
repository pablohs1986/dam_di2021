/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package di_gestionClientesExamen.gui.tableModel;

import di_gestionClientesExamen.dto.Cliente;
import java.text.SimpleDateFormat;
import java.util.List;
import javax.swing.table.AbstractTableModel;

/**
 *
 * @author Pablo Herrero
 */
public class ClientesTableModel extends AbstractTableModel {

    List<Cliente> listaClientes;
    String[] cabeceras = {"DNI", "Nombre", "Apellidos", "Fecha inicio", "Dirección", "Localidad", "Provincia", "CP", "Teléfono", "Email"};

    public ClientesTableModel(List<Cliente> listaClientes) {
        this.listaClientes = listaClientes;
    }
    
    @Override
    public String getColumnName(int column) {
        return cabeceras[column];
    }
    
    @Override
    public int getRowCount() {
        return listaClientes.size();
    }

    @Override
    public int getColumnCount() {
        return cabeceras.length;
    }

    @Override
    public Object getValueAt(int rowIndex, int columnIndex) {
        switch(columnIndex) {
            case 0: 
                return listaClientes.get(rowIndex).getDni();
            case 1:
                return listaClientes.get(rowIndex).getNombre();
            case 2:
                return listaClientes.get(rowIndex).getApellidos();
            case 3:
                SimpleDateFormat formateadorFecha = new SimpleDateFormat("dd/MM/yyyy");
                return formateadorFecha.format(listaClientes.get(rowIndex).getFechaInicio());
            case 4:
                return listaClientes.get(rowIndex).getDireccion();
            case 5:
                return listaClientes.get(rowIndex).getLocalidad();
            case 6:
                return listaClientes.get(rowIndex).getProvincia();
            case 7:
                return listaClientes.get(rowIndex).getCp();
            case 8:
                return listaClientes.get(rowIndex).getTelefono();
            case 9:
                return listaClientes.get(rowIndex).getEmail();
        }
        return null;
    }
    
    public void refrescar(){
        fireTableDataChanged();
    }
    
}
