/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package di_repaso_componentes_botonCalcu;

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
public class BotonCalcu extends JButton implements Serializable {

    private Color colorAlPasarEncima, colorInicial;
    private Font fuenteAlPasarEncima, fuenteInicial;

    public BotonCalcu() {
        super();
        this.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseExited(MouseEvent e) {
                setFont(fuenteInicial);
                setForeground(colorInicial);
            }

            @Override
            public void mouseEntered(MouseEvent e) {
                setFont(fuenteAlPasarEncima);
                setForeground(colorAlPasarEncima);
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

}
