   M S B A M L   `   `   `  ����I  EexamenAlmacen1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:examenAlmacen1examenAlmacen1  5   	       examenAlmacen1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:examenAlmacen1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   o� -   5         o�Name$ menuMenu��5
      $��Center=�6!   $��31��6>   $
��10,0q�6J   $	��Top=�6X   $	��774��6p   .@�5      m� -   5         m�Name$ miMenu��5      $��Insertar��6'   $��28��69   $	��100��6E   6Q   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgProductos��5         AutoGenerateColumns .     CanUserAddRows .  $��Center=�6�   $	��260��6�   $��
10,82,10,0q�6�   $	��Top=�6�   $	��774��6�   ��6(   ��  �� Path$ listaProductos�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        Producto��,  &System.Windows.Controls.DataGridColumn   Header$ Producto��5   7   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6I   �� $ Producto�  5      -   5        	Categoria��$ 
Categoría��5   8   	 6K   �� $ 	Categoria�  5      -   5        	Stock��$ Stock��5   4   	 6C   �� $ Stock�5      �� 5   
   -   5        $��Center=�5      $��36��6/   $��
10,36,10,0q�6;   
 �� TextWrapping$

 Wrap=�6O   $��ALMACÉN��6c   $	��Top=�6r   $	��774��6�   $
��Bold"�6�    �� TextAlignment$ Center=�6�   $��22(�6�   ���	#FFF707076�   �� 5   
   -   5         ��Name$ btnSale��5      $
��Sale��6"   $
��Left=�61   $��693,372,0,0q�6L   $	��Top=�6a   $��75��6y   $y�Hidden=�6�   6�   �� 5   
   -	   5        $ btnEntra��5      $��Entra��6#   $
��Left=�63   $��580,372,0,0q�6N   $	��Top=�6c   $��75��6{   $y�Hidden=�6�   6�   �� 5   
   -
   5         ��Name$ cbProductos��5      $��Center=�6(   $��43,370,323,0q�6q   $	��Top=�6�   $	��428��6�   ��6E   �� $ listaProductos�6�   5      5      