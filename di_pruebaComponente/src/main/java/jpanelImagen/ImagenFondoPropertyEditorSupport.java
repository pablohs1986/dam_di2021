/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jpanelImagen;

import java.awt.Component;
import java.beans.PropertyEditorSupport;

/**
 *
 * @author Pablo Herrero
 */
public class ImagenFondoPropertyEditorSupport extends PropertyEditorSupport {

    private ImagenFondoPanel imagenFondoPanel = new ImagenFondoPanel();
    
    @Override
    public boolean supportsCustomEditor() {
        return true; // Para indicar que hay un editor personalizado.
    }

    @Override
    public Component getCustomEditor() {
        return imagenFondoPanel; // Pide el panel, lo que tiene que insertar en el editor de propiedades.
    }

    @Override
    public String getJavaInitializationString() {
        ImagenFondo imagenFondo = imagenFondoPanel.getSelectedValue();
        return "new panelimagen.ImagenFondo(new java.io.File(\""+imagenFondo.getRutaImagen().getAbsolutePath().replace("\\","\\\\")+"\"),"+imagenFondo.getOpacidad()+"f)"; // Hace falta para que compile, si no sólo funcionaria en tiempo de diseño.
    }

    @Override
    public Object getValue() {
        return imagenFondoPanel.getSelectedValue(); // Devuelve el valor que selecciona el usuario.
    }
    
}
