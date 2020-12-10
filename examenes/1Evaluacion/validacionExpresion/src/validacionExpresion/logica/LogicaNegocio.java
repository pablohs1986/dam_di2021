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

    private static List<Expresion> listaExpresiones = new ArrayList<>();

    public LogicaNegocio() {
    }

    public List<Expresion> getListaExpresiones() {
        return listaExpresiones;
    }

    public void setListaExpresiones(List<Expresion> listaExpresiones) {
        this.listaExpresiones = listaExpresiones;
    }

    public static void aniadirExpresion(Expresion expresion) {
        listaExpresiones.add(expresion);
    }

}
