   M S B A M L   `   `   `  ����Q  MPruebaExamen2evalPablo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:PruebaExamen2evalPabloPruebaExamen2evalPablo  5   	   '    !PruebaExamen2evalPablo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:PruebaExamen2evalPablo     5   	     � Title$  
MainWindow��5   	   $��591.291��6   $��630.717��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��275* �6   �� 5      $
��287* �6   .+�5   
   o� -   5         o�Name$ menuPantallaPrincipal��5      $��37��6.   $	��Top=�6:   $
��10,0q�6R   $��Center=�6`   $	��605��6}   .@�5      m� -   5         m�Name$ menuAñadir��5      $��Añadir��6+   $��37��6;   $	��100��6G   6S   5      �� 5   
   -   5         ��Name$ 
cbSelector��5      $��Center=�6R   $��21,196,255,0q�6o   $	��Top=�6�   $	��349��6�   $��40��6�   $��1��6�   ��6'   ��  �� Path$ ListaPersonas�6�   �� 5   
   -   5         ��Name$ btnEntra��5      $��Entra��6#   $��396,196,138,0q�63   $��1��6J   $��40��6W   $	��Top=�6c   6{   �� 5   
   -   5        $ btnSale��5      $
��Sale��6"   $��503,196,0,0q�61   $��1��6F   $
��Left=�6S   $��86��6n   $��40��6y   $	��Top=�6�   6�   �� 5   
   -   5         ��Name$ tbTitulo��5      $��21,54,22,181q�6$    �� TextWrapping$
 Wrap=�6:   $��BLABLABLALB��6N   $��Center=�6�   $	��582��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dgDatos��5      $
��Left=�6O   $	��323��6j   $��
21,121,0,0q�6w   $	��Top=�6�   $	��582��6�   $��2��6�   
   CanUserAddRows
 .  ��6$   �� $ ListaPersonas�6�   5      5      