/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ingresosGastos.gui.tableModel;

import ingresosGastos.dto.IngresoGasto;
import java.text.DecimalFormat;
import java.text.SimpleDateFormat;
import java.util.List;
import javax.swing.table.AbstractTableModel;

/**
 *
 * @author Pablo Herrero
 */
public class IngresosGastosTableModel extends AbstractTableModel{
    private List<IngresoGasto> listaIngresosGastos;
    private String[] cabeceras = {"Fecha", "Concepto", "Importe"};

    public IngresosGastosTableModel(List<IngresoGasto> listaIngresosGastos) {
        this.listaIngresosGastos = listaIngresosGastos;
    }
    
    @Override
    public int getRowCount() {
        return listaIngresosGastos.size();
    }

    @Override
    public int getColumnCount() {
        return cabeceras.length;
    }

    @Override
    public Object getValueAt(int rowIndex, int columnIndex) {
        switch (columnIndex) {
            case 0: {
                SimpleDateFormat formateador = new SimpleDateFormat("dd/MM/yyyy"); //formateamos la fecha
                return formateador.format(listaIngresosGastos.get(rowIndex).getFecha());
            }
            case 1:
                return listaIngresosGastos.get(rowIndex).getConcepto();
            case 2:
                if (listaIngresosGastos.get(rowIndex).getIngreso() == 0) {
                    return null;
                } else {
                    return new DecimalFormat("#0.00#").format(listaIngresosGastos.get(rowIndex).getIngreso()); // redondea a 2 decimales
                }
            case 3:
                if (listaIngresosGastos.get(rowIndex).getGasto() == 0) {
                    return null;
                } else {
                    return new DecimalFormat("#0.00#").format(listaIngresosGastos.get(rowIndex).getGasto()); // redondea a 2 decimales
                }
        }
        return null;
    }

    @Override
    public String getColumnName(int column) {
        return cabeceras[column];
    }
    
    public void deleteRow(int row) {
        if(!(listaIngresosGastos.size()==0)) {
            listaIngresosGastos.remove(row);
            fireTableDataChanged();
        }
    }
    
    public void refrescar(){
        fireTableDataChanged();
    }
}
