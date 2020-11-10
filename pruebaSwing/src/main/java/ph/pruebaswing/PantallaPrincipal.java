/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ph.pruebaswing;

/**
 *
 * @author Pablo Herrero
 */
public class PantallaPrincipal extends javax.swing.JFrame {

    /**
     * Creates new form PantallaPrincipal
     */
    public PantallaPrincipal() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jT_Euro = new javax.swing.JTextField();
        jC_Divisa = new javax.swing.JComboBox<>();
        jScrollPane1 = new javax.swing.JScrollPane();
        jT_Resultado = new javax.swing.JTextArea();
        jB_Convertir = new javax.swing.JButton();
        jB_Salir = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jB_AnadirDivisa = new javax.swing.JButton();
        jMenuBar1 = new javax.swing.JMenuBar();
        jMenu1 = new javax.swing.JMenu();
        jM_Salir = new javax.swing.JMenuItem();
        jMenu2 = new javax.swing.JMenu();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jT_Euro.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jT_EuroActionPerformed(evt);
            }
        });

        jC_Divisa.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Dolar", "Yen", "Libra" }));
        jC_Divisa.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jC_DivisaActionPerformed(evt);
            }
        });

        jT_Resultado.setColumns(20);
        jT_Resultado.setRows(5);
        jScrollPane1.setViewportView(jT_Resultado);

        jB_Convertir.setText("Convertir");
        jB_Convertir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jB_ConvertirActionPerformed(evt);
            }
        });

        jB_Salir.setText("Salir");
        jB_Salir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jB_SalirActionPerformed(evt);
            }
        });

        jLabel1.setText("Euro");

        jLabel2.setText("Divisa");

        jB_AnadirDivisa.setText("Añadir divisa");
        jB_AnadirDivisa.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jB_AnadirDivisaActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(106, 106, 106)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(101, 101, 101)
                        .addComponent(jB_Convertir)
                        .addGap(64, 64, 64)
                        .addComponent(jB_Salir, javax.swing.GroupLayout.PREFERRED_SIZE, 75, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addGap(8, 8, 8)
                                .addComponent(jLabel1)
                                .addGap(332, 332, 332))
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addComponent(jT_Euro)
                                .addGap(124, 124, 124)))
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel2)
                            .addComponent(jC_Divisa, javax.swing.GroupLayout.PREFERRED_SIZE, 147, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jB_AnadirDivisa))))
                .addContainerGap(88, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(87, 87, 87)
                        .addComponent(jLabel2))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jLabel1)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jT_Euro, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jC_Divisa, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(59, 59, 59)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 151, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addGap(18, 18, 18)
                        .addComponent(jB_AnadirDivisa)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 99, Short.MAX_VALUE)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jB_Convertir)
                            .addComponent(jB_Salir))
                        .addGap(129, 129, 129))))
        );

        jMenu1.setText("File");

        jM_Salir.setText("Salir");
        jM_Salir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jM_SalirActionPerformed(evt);
            }
        });
        jMenu1.add(jM_Salir);

        jMenuBar1.add(jMenu1);

        jMenu2.setText("Edit");
        jMenuBar1.add(jMenu2);

        setJMenuBar(jMenuBar1);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jB_SalirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jB_SalirActionPerformed
        System.exit(0);
    }//GEN-LAST:event_jB_SalirActionPerformed

    private void jM_SalirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jM_SalirActionPerformed
        System.exit(0);
    }//GEN-LAST:event_jM_SalirActionPerformed

    private void jT_EuroActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jT_EuroActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jT_EuroActionPerformed

    private void jC_DivisaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jC_DivisaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jC_DivisaActionPerformed

    private void jB_ConvertirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jB_ConvertirActionPerformed
        convertir();
    }//GEN-LAST:event_jB_ConvertirActionPerformed

    private void jB_AnadirDivisaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jB_AnadirDivisaActionPerformed
        PantallaNuevaDivisaDialogo nuevaPantalla = new PantallaNuevaDivisaDialogo(this, true);
        
        nuevaPantalla.setVisible(true);
    }//GEN-LAST:event_jB_AnadirDivisaActionPerformed

    private void convertir() {
        double valorEuro =  Double.parseDouble(jT_Euro.getText());
        String divisa = jC_Divisa.getModel().getSelectedItem().toString();
        double resultado = 0 ;
        
        switch (divisa) {
            case "Dolar":
                resultado = valorEuro * 1.19;
                break;
                
            case "Yen":
                resultado = valorEuro * 124.27;
                break;
                
            case "Libra":
                resultado = valorEuro * 0.91;
                break;
        }
        
        jT_Resultado.setText(String.valueOf(resultado));
        
    }
    
    public void anadirDivisa(String nombreDivisa, String valorDivisa) {
        jC_Divisa.addItem(nombreDivisa);
        jT_Resultado.setText((nombreDivisa + valorDivisa));
    }
    
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
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
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
    private javax.swing.JButton jB_AnadirDivisa;
    private javax.swing.JButton jB_Convertir;
    private javax.swing.JButton jB_Salir;
    private javax.swing.JComboBox<String> jC_Divisa;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JMenuItem jM_Salir;
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenu jMenu2;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextField jT_Euro;
    private javax.swing.JTextArea jT_Resultado;
    // End of variables declaration//GEN-END:variables
}