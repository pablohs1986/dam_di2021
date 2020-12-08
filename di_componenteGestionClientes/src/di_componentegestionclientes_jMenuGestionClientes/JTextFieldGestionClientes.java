/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package di_componentegestionclientes_jMenuGestionClientes;

import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.io.Serializable;
import java.text.NumberFormat;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

/**
 *
 * @author Pablo Herrero
 */
public class JTextFieldGestionClientes extends JTextField implements Serializable{
    
    private int longitud;
    private boolean es_numerico;
    
    public JTextFieldGestionClientes() {
        super();
        
        this.addKeyListener(new KeyAdapter() {
            @Override
            public void keyTyped(KeyEvent e) {
                if(es_numerico){
                    System.out.println(e.getKeyChar());
                    String patronSoloNumeros = "^[^A-Za-z]";
                    Pattern pattern = Pattern.compile(patronSoloNumeros);
                    Matcher matcher = pattern.matcher(Character.toString(e.getKeyChar()));

                    if (!matcher.matches()) {
                        System.out.println("coincide");
                        e.consume();
                    }
                }
            }
        });

        this.addKeyListener(new KeyAdapter() {
            @Override
            public void keyTyped(KeyEvent e) {
                if(getText().length() >= longitud) {
                    e.consume(); 
                } 
            }
        });
        
    }

    public int getLongitud() {
        return longitud;
    }

    public void setLongitud(int longitud) {
        this.longitud = longitud;
    }

    public boolean isEs_numerico() {
        return es_numerico;
    }

    public void setEs_numerico(boolean es_numerico) {
        this.es_numerico = es_numerico;
    }
    
//    public void comprobarNumeroCaracteres() {
//       if(this.getText().length() >= longitud) {
//           this.setEditable(false);
//       } else {
//           this.setEditable(true);
//           this.set
//       }
//    }
    

}
