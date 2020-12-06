/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package rugby.dto;

import java.util.Date;

/**
 *
 * @author Pablo Herrero
 */
public class Partido {
    private String equipoLocal;
    private String equipoVisitante;
    private Division divisionPartido;
    private String resultado;
    private Date fecha;

    public Partido(String equipoLocal, String equipoVisitante, Division divisionPartido, String resultado, Date fecha) {
        this.equipoLocal = equipoLocal;
        this.equipoVisitante = equipoVisitante;
        this.divisionPartido = divisionPartido;
        this.resultado = resultado;
        this.fecha = fecha;
    }

    public String getEquipoLocal() {
        return equipoLocal;
    }

    public void setEquipoLocal(String equipoLocal) {
        this.equipoLocal = equipoLocal;
    }

    public String getEquipoVisitante() {
        return equipoVisitante;
    }

    public void setEquipoVisitante(String equipoVisitante) {
        this.equipoVisitante = equipoVisitante;
    }

    public Division getDivisionPartido() {
        return divisionPartido;
    }

    public void setDivisionPartido(Division divisionPartido) {
        this.divisionPartido = divisionPartido;
    }

    public String getResultado() {
        return resultado;
    }

    public void setResultado(String resultado) {
        this.resultado = resultado;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }
    
    
    
}
