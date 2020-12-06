/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package di_calculadora.gui.tableModel;

import di_calculadora.dto.Operacion;
import java.text.SimpleDateFormat;
import java.util.List;
import javax.swing.table.AbstractTableModel;

/**
 *
 * @author Pablo Herrero
 */
public class CalculadoraTableModel extends AbstractTableModel {

    private List<Operacion> listadoOperaciones;
    private String[] cabeceras = {"Fecha", "Hora", "Operación"};

    public CalculadoraTableModel(List<Operacion> listadoOperaciones) {
        this.listadoOperaciones = listadoOperaciones;
    }
    
    @Override
    public int getRowCount() {
        return listadoOperaciones.size();
    }

    @Override
    public int getColumnCount() {
        return cabeceras.length;
    }

    @Override
    public Object getValueAt(int rowIndex, int columnIndex) {
        switch (columnIndex) {
            case 0:
                SimpleDateFormat formateadorFecha = new SimpleDateFormat("dd:MM:yyyy");
                return formateadorFecha.format(listadoOperaciones.get(rowIndex).getFecha());
            case 1:
                return listadoOperaciones.get(rowIndex).getHora();
            case 2:
                return listadoOperaciones.get(rowIndex).getOperacion();
        }
        return null;
    }

    @Override
    public String getColumnName(int column) {
        return cabeceras[column];
    }
    
    public void refrescar() {
        fireTableDataChanged();
    }
    
}
