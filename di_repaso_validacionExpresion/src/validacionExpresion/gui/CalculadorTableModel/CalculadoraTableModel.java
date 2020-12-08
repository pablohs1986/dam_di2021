/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package validacionExpresion.gui.CalculadorTableModel;

import java.text.SimpleDateFormat;
import java.util.List;
import javax.swing.table.AbstractTableModel;
import validacionExpresion.dto.Expresion;

/**
 *
 * @author Pablo Herrero
 */
public class CalculadoraTableModel extends AbstractTableModel {
    List<Expresion> listadoExpresiones;
    String[] cabeceras = {"Fecha", "Hora", "Operación"};

    public CalculadoraTableModel(List<Expresion> listadoExpresiones) {
        this.listadoExpresiones = listadoExpresiones;
    }
    
    @Override
    public int getRowCount() {
        return listadoExpresiones.size();
    }

    @Override
    public int getColumnCount() {
        return cabeceras.length;
    }

    @Override
    public Object getValueAt(int rowIndex, int columnIndex) {
        switch(columnIndex) {
            case 0:
                SimpleDateFormat formateadorFecha = new SimpleDateFormat("dd/MM/yyyy");
                return formateadorFecha.format(listadoExpresiones.get(rowIndex).getFecha());
            case 1:
                return listadoExpresiones.get(rowIndex).getHora();
            case 2:
                return listadoExpresiones.get(rowIndex).getOperacion();
        }
        return null;
    }

    @Override
    public String getColumnName(int column) {
        return cabeceras[column];
    }
    
    public void refrescarTabla(){
        fireTableDataChanged();
    }
    
    
}
