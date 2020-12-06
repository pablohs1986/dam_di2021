/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package rugby.logica;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.Date;
import java.util.List;
import rugby.dto.Partido;

/**
 *
 * @author Pablo Herrero
 */
public class LogicaNegocio {
    private List<Partido> listaPartidos;

    public LogicaNegocio(List<Partido> listaPartidos) {
        this.listaPartidos = listaPartidos;
    }
    
    public void anadirPartido(Partido partido) {
        this.listaPartidos.add(partido);
    }
    
    public void borrarPartido(Partido partido) {
        this.listaPartidos.remove(partido);
    }
    
//    public void ordenarListaPorFecha(){
//        listaPartidos.sort(Comparator.comparing(date -> date.Date());
//    }
    
}
