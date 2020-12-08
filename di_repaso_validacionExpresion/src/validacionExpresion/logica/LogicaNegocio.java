/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package validacionExpresion.logica;

import java.util.ArrayList;
import java.util.List;
import validacionExpresion.dto.Expresion;

/**
 *
 * @author Pablo Herrero
 */
public class LogicaNegocio {
    private static List<Expresion> listadoExpresiones = new ArrayList<>();

    public LogicaNegocio() {
    }

    public List<Expresion> getListadoExpresiones() {
        return listadoExpresiones;
    }

    public void setListadoExpresiones(List<Expresion> listadoExpresiones) {
        this.listadoExpresiones = listadoExpresiones;
    }
    
    public static void aniadirExpresion(Expresion expresion){
        listadoExpresiones.add(expresion);
    }
}
