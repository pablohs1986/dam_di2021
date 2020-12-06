
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.logging.Level;
import java.util.logging.Logger;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Pablo Herrero
 */
public class PruebaFechas {
    public static void main(String[] args) {
        SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyy");
        Date fecha = new Date();    
        System.out.println(sdf.format(fecha));
        
        // Caso de String a fecha
        String fechaCadena = "10-10-2010";
        try {
            fecha = sdf.parse(fechaCadena);
        } catch (ParseException ex) {
            ex.getMessage();
        }
        System.out.println(fecha.toString());
    }
}
