/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ingresosGastos.dto;

import java.text.SimpleDateFormat;
import java.util.Date;

/**
 *
 * @author Pablo Herrero
 */
public class IngresoGasto {
    private Date fecha;
    private String concepto;
    private double gasto;
    private double ingreso;

    public IngresoGasto(Date fecha, String concepto, double importe) {
        this.fecha = fecha;
        this.concepto = concepto;
        if (importe >= 0) {
            this.ingreso = importe;
        } else if (importe < 0)  {
            this.gasto = importe;
        }
    }

    public String getConcepto() {
        return concepto;
    }

    public void setConcepto(String concepto) {
        this.concepto = concepto;
    }

    public double getGasto() {
        return gasto;
    }

    public void setGasto(double gasto) {
        this.gasto = gasto;
    }

    public double getIngreso() {
        return ingreso;
    }

    public void setIngreso(double ingreso) {
        this.ingreso = ingreso;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }
    
}
