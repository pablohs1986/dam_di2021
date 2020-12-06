/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package garaje.dto;

import java.util.Date;

/**
 *
 * @author Pablo Herrero
 */
public class Vehiculo {
    private Date fechaEntrada;
    private TipoVehiculo tipo;
    private String modelo;
    private String matricula;
    private String longitud;
    private Boolean peligroso;
    private Propietario propietario;

    public Vehiculo(Date fechaEntrada, TipoVehiculo tipo, String modelo, String matricula, Propietario propietario) {
        this.fechaEntrada = fechaEntrada;
        this.tipo = tipo;
        this.modelo = modelo;
        this.matricula = matricula;
        this.propietario = propietario;
    }

    public Vehiculo(Date fechaEntrada, TipoVehiculo tipo, String modelo, String matricula, String longitud, Boolean peligroso, Propietario propietario) {
        this.fechaEntrada = fechaEntrada;
        this.tipo = tipo;
        this.modelo = modelo;
        this.matricula = matricula;
        this.longitud = longitud;
        this.peligroso = peligroso;
        this.propietario = propietario;
    }

    public Propietario getPropietario() {
        return propietario;
    }

    public void setPropietario(Propietario propietario) {
        this.propietario = propietario;
    }

    public Date getFechaEntrada() {
        return fechaEntrada;
    }

    public void setFechaEntrada(Date fechaEntrada) {
        this.fechaEntrada = fechaEntrada;
    }

    public TipoVehiculo getTipo() {
        return tipo;
    }

    public void setTipo(TipoVehiculo tipo) {
        this.tipo = tipo;
    }

    public String getModelo() {
        return modelo;
    }

    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    public String getMatricula() {
        return matricula;
    }

    public void setMatricula(String matricula) {
        this.matricula = matricula;
    }

    public String getLongitud() {
        return longitud;
    }

    public void setLongitud(String longitud) {
        this.longitud = longitud;
    }

    public Boolean getPeligroso() {
        return peligroso;
    }

    public void setPeligroso(Boolean peligroso) {
        this.peligroso = peligroso;
    }
    
    
}
