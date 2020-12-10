/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package botoncalculadora;

import java.awt.Color;
import java.awt.Font;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.io.Serializable;
import javax.swing.JButton;

/**
 *
 * @author Pablo Herrero
 */
public class botonCalculadora extends JButton implements Serializable {

    private Color colorInicial, colorAlPasar;
    private Font fuenteInicial, fuenteAlPasar; // Añadí las propiedades de la fuente para darle mayor funcionalidad, aunque realmente en el ejercicio no se pide.
    
    public botonCalculadora() {
        super();
        
        this.addMouseListener(new MouseAdapter() {
            // Segun el evento, asigno la propiedad que me interesa
            @Override
            public void mouseExited(MouseEvent e) {
                setForeground(colorInicial);
                setFont(fuenteInicial);
            }
            
            @Override
            public void mouseEntered(MouseEvent e) {
                setForeground(colorAlPasar);
                setFont(fuenteAlPasar);
            }
            
        });
    }
    
    public Color getColorInicial() {
        return colorInicial;
    }
    
    public void setColorInicial(Color colorInicial) {
        super.setForeground(colorInicial); // Invoco el setForeground de la case padre para asignarle el color inicial por defecto
        this.colorInicial = colorInicial;
    }
    
    public Color getColorAlPasar() {
        return colorAlPasar;
    }
    
    public void setColorAlPasar(Color colorAlPasar) {
        this.colorAlPasar = colorAlPasar;
    }
    
    public Font getFuenteInicial() {
        return fuenteInicial;
    }
    
    public void setFuenteInicial(Font fuenteInicial) {
        super.setFont(fuenteInicial);
        this.fuenteInicial = fuenteInicial;
    }
    
    public Font getFuenteAlPasar() {
        return fuenteAlPasar;
    }
    
    public void setFuenteAlPasar(Font fuenteAlPasar) {
        this.fuenteAlPasar = fuenteAlPasar;
    }
    
}
