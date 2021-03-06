/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package di_gestionClientesExamen.gui;

import java.io.File;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.help.HelpBroker;
import javax.help.HelpSet;
import javax.help.HelpSetException;
import javax.swing.UIManager;

/**
 *
 * @author Pablo Herrero
 */
public class PantallaPrincipal extends javax.swing.JFrame {
    PantallaInsertar pantallaInsertar = new PantallaInsertar(this, false);
    PantallaLista pantallaLista = new PantallaLista(this, true);
    /**
     * Creates new form PantallaPrincipal
     */
    public PantallaPrincipal() {
        initComponents();
        try {
            cargarAyuda();
        } catch (MalformedURLException ex) {
            Logger.getLogger(PantallaPrincipal.class.getName()).log(Level.SEVERE, null, ex);
        } catch (HelpSetException ex) {
            Logger.getLogger(PantallaPrincipal.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    private void cargarAyuda() throws MalformedURLException, HelpSetException, HelpSetException {
        // Carga el fichero de ayuda
        File fichero = new File("./help/help_set.hs");
        URL hsURL = fichero.toURI().toURL();
        // Crea el HelpSet y el HelpBroker
        HelpSet helpset = new HelpSet(getClass().getClassLoader(), hsURL);
        HelpBroker hb = helpset.createHelpBroker();
        // Pone ayuda a item de menu al pulsarlo.
        hb.enableHelpKey(this.getContentPane(), "principal", helpset);
        hb.enableHelpKey(pantallaInsertar.getContentPane(), "insertar", helpset);
        hb.enableHelpKey(pantallaLista.getContentPane(), "listar", helpset);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jButton1 = new javax.swing.JButton();
        jMenuBar1 = new javax.swing.JMenuBar();
        menuGestionClientesInsertar = new di_componentegestionclientes_jMenuGestionClientes.MenuGestionClientes();
        menuGestionClientesLista = new di_componentegestionclientes_jMenuGestionClientes.MenuGestionClientes();
        menuGestionClientesImprimir = new di_componentegestionclientes_jMenuGestionClientes.MenuGestionClientes();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Gestión clientes");
        getContentPane().setLayout(new java.awt.CardLayout());

        jButton1.setIcon(new javax.swing.ImageIcon("C:\\Users\\pablo\\Documents\\DAM\\Segundo\\DI\\Repositorio\\di_gestionClientesExamen\\Clientes.jpg")); // NOI18N
        getContentPane().add(jButton1, "card2");

        menuGestionClientesInsertar.setText("Insertar");
        menuGestionClientesInsertar.setColorAlPasarEncima(new java.awt.Color(0, 0, 153));
        menuGestionClientesInsertar.setColorInicial(new java.awt.Color(0, 0, 0));
        menuGestionClientesInsertar.setFuenteAlPasarEncima(new java.awt.Font("Arial", 1, 14)); // NOI18N
        menuGestionClientesInsertar.setFuenteInicial(new java.awt.Font("Arial", 0, 14)); // NOI18N
        menuGestionClientesInsertar.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                menuGestionClientesInsertarMouseClicked(evt);
            }
        });
        jMenuBar1.add(menuGestionClientesInsertar);

        menuGestionClientesLista.setText("Lista");
        menuGestionClientesLista.setColorAlPasarEncima(new java.awt.Color(0, 0, 153));
        menuGestionClientesLista.setColorInicial(new java.awt.Color(0, 0, 0));
        menuGestionClientesLista.setFuenteAlPasarEncima(new java.awt.Font("Arial", 1, 14)); // NOI18N
        menuGestionClientesLista.setFuenteInicial(new java.awt.Font("Arial", 0, 14)); // NOI18N
        menuGestionClientesLista.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                menuGestionClientesListaMouseClicked(evt);
            }
        });
        jMenuBar1.add(menuGestionClientesLista);

        menuGestionClientesImprimir.setText("Imprimir");
        menuGestionClientesImprimir.setColorAlPasarEncima(new java.awt.Color(0, 0, 153));
        menuGestionClientesImprimir.setColorInicial(new java.awt.Color(0, 0, 0));
        menuGestionClientesImprimir.setFuenteAlPasarEncima(new java.awt.Font("Arial", 1, 14)); // NOI18N
        menuGestionClientesImprimir.setFuenteInicial(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jMenuBar1.add(menuGestionClientesImprimir);

        setJMenuBar(jMenuBar1);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void menuGestionClientesInsertarMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_menuGestionClientesInsertarMouseClicked
        pantallaInsertar.setVisible(true);
    }//GEN-LAST:event_menuGestionClientesInsertarMouseClicked

    private void menuGestionClientesListaMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_menuGestionClientesListaMouseClicked
        pantallaLista.setVisible(true);
    }//GEN-LAST:event_menuGestionClientesListaMouseClicked

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            UIManager.setLookAndFeel("com.nilo.plaf.nimrod.NimRODLookAndFeel");
//            UIManager.setLookAndFeel("com.easynth.lookandfeel.EaSynthLookAndFeel");
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(PantallaPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(PantallaPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(PantallaPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(PantallaPrincipal.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new PantallaPrincipal().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JMenuBar jMenuBar1;
    private di_componentegestionclientes_jMenuGestionClientes.MenuGestionClientes menuGestionClientesImprimir;
    private di_componentegestionclientes_jMenuGestionClientes.MenuGestionClientes menuGestionClientesInsertar;
    private di_componentegestionclientes_jMenuGestionClientes.MenuGestionClientes menuGestionClientesLista;
    // End of variables declaration//GEN-END:variables
}
