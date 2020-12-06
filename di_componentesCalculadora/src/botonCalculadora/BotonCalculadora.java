/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package botonCalculadora;

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
public class BotonCalculadora extends JButton implements Serializable{
    private Color colorInicial, fuenteAlPasarEncima;
    private Font fuenteInicial, colorAlPasarEncima;
    
    public BotonCalculadora() {
        this.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseExited(MouseEvent e) {
                setForeground(colorInicial);
                setFont(fuenteInicial);
            }

            @Override
            public void mouseEntered(MouseEvent e) {
                setForeground(fuenteAlPasarEncima);
                setFont(colorAlPasarEncima);
            }
        });
    }

    public Color getColorInicial() {
        return colorInicial;
    }

    public void setColorInicial(Color colorInicial) {
        super.setForeground(colorInicial);
        this.colorInicial = colorInicial;
    }

    public Color getColorAlPasar() {
        return fuenteAlPasarEncima;
    }

    public void setColorAlPasar(Color colorAlPasar) {
        this.fuenteAlPasarEncima = colorAlPasar;
    }

    public Font getFuenteInicial() {
        return fuenteInicial;
    }

    public void setFuenteInicial(Font fuenteInicial) {
        super.setFont(fuenteInicial);
        this.fuenteInicial = fuenteInicial;
    }

    public Font getFuenteAlPasar() {
        return colorAlPasarEncima;
    }

    public void setFuenteAlPasar(Font fuenteAlPasar) {
        this.colorAlPasarEncima = fuenteAlPasar;
    }
    
}
