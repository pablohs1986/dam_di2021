/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package garaje.logica;

import garaje.dto.Vehiculo;
import java.util.List;
import java.util.ArrayList;

/**
 *
 * @author Pablo Herrero
 */
public class LogicaNegocio {
    private static List<Vehiculo> listaVehiculos = new ArrayList<>();
    
    public static void anadirVehiculo(Vehiculo vehiculo) {
        listaVehiculos.add(vehiculo);
    }

    public static List<Vehiculo> getListaVehiculos() {
        return listaVehiculos;
    }
    
    
}
