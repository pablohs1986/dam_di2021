/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package validacionExpresion.gui.tableModel;

import java.text.SimpleDateFormat;
import java.util.List;
import javax.swing.table.AbstractTableModel;
import validacionExpresion.dto.Expresion;

/**
 *
 * @author Pablo Herrero
 */
public class CalculadoraTableModel extends AbstractTableModel {

    private List<Expresion> listaExpresiones;
    private String[] cabeceras = {"Fecha", "Hora", "Operación"};

    public CalculadoraTableModel(List<Expresion> listaExpresiones) {
        this.listaExpresiones = listaExpresiones;
    }

    @Override
    public int getRowCount() {
        return listaExpresiones.size();
    }

    @Override
    public int getColumnCount() {
        return cabeceras.length;
    }

    @Override
    public Object getValueAt(int rowIndex, int columnIndex) {
        switch (columnIndex) {
            case 0:
                SimpleDateFormat formateadorFecha = new SimpleDateFormat("dd/MM/yyyy");
                return formateadorFecha.format(listaExpresiones.get(rowIndex).getFecha());
            case 1:
                return listaExpresiones.get(rowIndex).getHora();
            case 2:
                return listaExpresiones.get(rowIndex).getOperacion();
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
