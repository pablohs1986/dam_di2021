/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ingresosGastos.logica;

import ingresosGastos.dto.IngresoGasto;
import java.util.List;
import java.util.ArrayList;

/**
 *
 * @author Pablo Herrero
 */
public class LogicaNegocio {
    private static List<IngresoGasto> listaIngresosGastos = new ArrayList<>();
    
    public static void anadirIngresoGasto(IngresoGasto ingresoGasto) {
        listaIngresosGastos.add(ingresoGasto);
    }

    public static List<IngresoGasto> getListaIngresosGastos() {
        return listaIngresosGastos;
    }
    
    public static double calcularBalance() {
        double balance = 0;
        for (IngresoGasto ingresoGasto : listaIngresosGastos) {
            balance += ingresoGasto.getIngreso() + ingresoGasto.getGasto();
        }
        return balance;
    }
    
    
    
}
