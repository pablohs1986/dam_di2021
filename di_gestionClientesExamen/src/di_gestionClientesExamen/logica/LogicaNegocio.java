/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package di_gestionClientesExamen.logica;

import di_gestionClientesExamen.dto.Cliente;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Pablo Herrero
 */
public class LogicaNegocio {
    private static List<Cliente> listadoClientes = new ArrayList<>();

    public LogicaNegocio() {
    }

    public List<Cliente> getListadoClientes() {
        return listadoClientes;
    }

    public void setListadoClientes(List<Cliente> listadoClientes) {
        this.listadoClientes = listadoClientes;
    }
    
    public static void anadirCliente(Cliente cliente) {
        listadoClientes.add(cliente);
    }
}
