/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gestionClientes.logica;

import gestionClientes.dto.Cliente;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Pablo Herrero
 */
// Sólo se encarga de almacenar la lista de clientes.
public class LogicaNegocio {
    private static List<Cliente> listaClientes = new ArrayList<>();
    
    public static void anadirCliente(Cliente cliente) {
        listaClientes.add(cliente);
    }

    public static List<Cliente> getListaClientes() {
        return listaClientes;
    }
    
}
