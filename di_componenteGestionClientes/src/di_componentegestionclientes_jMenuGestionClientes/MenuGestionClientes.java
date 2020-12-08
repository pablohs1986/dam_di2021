/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package di_componentegestionclientes_jMenuGestionClientes;

import java.awt.Color;
import java.awt.Font;
import java.awt.Toolkit;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.io.Serializable;
import javax.swing.JMenu;

/**
 *
 * @author Pablo Herrero
 */
public class MenuGestionClientes extends JMenu implements Serializable {
    
    private Color colorAlPasarEncima, colorInicial;
    private Font fuenteAlPasarEncima, fuenteInicial;
    private boolean beep;

    public MenuGestionClientes() { 
        super();
        this.addMouseListener(new MouseAdapter() { // Repasar cómo crearlo
            @Override
            public void mouseExited(MouseEvent e) {
                setForeground(colorInicial);
                setFont(fuenteInicial);
            }

            @Override
            public void mouseEntered(MouseEvent e) {
                setForeground(colorAlPasarEncima);
                setFont(fuenteAlPasarEncima);
            }

            @Override
            public void mouseClicked(MouseEvent e) {
                Toolkit.getDefaultToolkit().beep();
            }
        });
    }

    public Color getColorAlPasarEncima() {
        return colorAlPasarEncima;
    }

    public void setColorAlPasarEncima(Color colorAlPasarEncima) {
        this.colorAlPasarEncima = colorAlPasarEncima;
    }

    public Color getColorInicial() {
        return colorInicial;
    }

    public void setColorInicial(Color colorInicial) {
        super.setForeground(colorInicial);
        this.colorInicial = colorInicial;
    }

    public Font getFuenteAlPasarEncima() {
        return fuenteAlPasarEncima;
    }

    public void setFuenteAlPasarEncima(Font fuenteAlPasarEncima) {
        this.fuenteAlPasarEncima = fuenteAlPasarEncima;
    }

    public Font getFuenteInicial() {
        return fuenteInicial;
    }

    public void setFuenteInicial(Font fuenteInicial) {
        super.setFont(fuenteInicial);
        this.fuenteInicial = fuenteInicial;
    }

    public boolean isBeep() {
        return beep;
    }

    public void setBeep(boolean beep) {
        this.beep = beep;
    }
    
    
    
   
    
}
