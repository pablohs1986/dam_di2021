/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package di_calculadora.logica;

import di_calculadora.dto.Operacion;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Pablo Herrero
 */
public class LogicaNegocio {

    private static List<Operacion> listaOperaciones = new ArrayList<>();

    public LogicaNegocio() {
    }

    public static void anadirOperacion(Operacion operacion) {
        listaOperaciones.add(operacion);
    }

    public List<Operacion> getListaOperaciones() {
        return listaOperaciones;
    }

    public void setListaOperaciones(List<Operacion> listaOperaciones) {
        this.listaOperaciones = listaOperaciones;
    }

}
