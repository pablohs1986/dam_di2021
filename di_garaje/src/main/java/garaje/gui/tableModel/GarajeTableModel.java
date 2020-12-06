/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package garaje.gui.tableModel;

import garaje.dto.TipoVehiculo;
import garaje.dto.Vehiculo;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;
import javax.swing.table.AbstractTableModel;

/**
 *
 * @author Pablo Herrero
 */
public class GarajeTableModel extends AbstractTableModel {
    private String[] cabeceras = {"Matrícula", "Tipo", "Modelo", "Peligroso", "Longitud", "Fecha de entrada", "DNI", "Nombre", "Apellidos", "Teléfono"};
    private List<Vehiculo> listaVehiculos;

    public GarajeTableModel(List<Vehiculo> listaVehiculos) {
        this.listaVehiculos = listaVehiculos;
    }
    
    @Override
    public int getRowCount() {
        return listaVehiculos.size();
    }

    @Override
    public int getColumnCount() {
        return cabeceras.length;
    }

    @Override
    public Object getValueAt(int rowIndex, int columnIndex) {
        TipoVehiculo tipo = listaVehiculos.get(rowIndex).getTipo();
        switch(columnIndex) {
            case 0: 
                return listaVehiculos.get(rowIndex).getMatricula();
            case 1:
                return listaVehiculos.get(rowIndex).getTipo();
            case 2:
                return listaVehiculos.get(rowIndex).getModelo();
            case 3:
                switch(tipo) {
                    case COCHE:
                        return "-";
                    case FURGONETA:
                        return "-";
                    case CAMION:
                        if (listaVehiculos.get(rowIndex).getPeligroso()) {
                            return "Sí";
                        } else {
                            return "No";
                        }
                }
            case 4:
                switch(tipo) {
                    case COCHE:
                        return "-";
                    case FURGONETA:
                        return "-";
                    case CAMION:
                        return listaVehiculos.get(rowIndex).getLongitud();
                }
            case 5:
                SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
                return sdf.format(listaVehiculos.get(rowIndex).getFechaEntrada());
            case 6:
                return listaVehiculos.get(rowIndex).getPropietario().getDni();
            case 7: 
                return listaVehiculos.get(rowIndex).getPropietario().getNombre();
            case 8: 
                return listaVehiculos.get(rowIndex).getPropietario().getApellidos();
            case 9:
                return listaVehiculos.get(rowIndex).getPropietario().getTelefono();
        }
        return null;
    }

    @Override
    public String getColumnName(int column) {
        return cabeceras[column];
    }
    
    public void deleteRow(int row){
        listaVehiculos.remove(row);
        fireTableDataChanged();
    }
    
    public void refrescar(){
        fireTableDataChanged();
    }
}
