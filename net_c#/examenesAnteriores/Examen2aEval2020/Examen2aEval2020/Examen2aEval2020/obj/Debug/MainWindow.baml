   M S B A M L   `   `   `  ����K  GExamen2aEval2020, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Examen2aEval2020Examen2aEval2020  5   	   !    Examen2aEval2020.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Examen2aEval2020     5   	     � Title$$  Registro de entradas y salidas��5   	   $��384.285��60   $��425.856��6A    � WindowStartupLocation$ CenterScreen=�6Q   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgPersonas��5
         AutoGenerateColumns .  $	��209��6o   $��20,63.305,21.053,0q�6|   $	��Top=�6�    � UseLayoutRounding .     CanUserAddRows .  ��6'   ��  �� Path$ ListaPersonas�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 120 6U   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� $ Nombre�6U     5      $ 	Apellidos��6%   $		 220 6[   
 68   �� $ 	Apellidos�6[     5      $ Estado��6%   $	 50 6U   
 65   �� $ Estado�6U   5      �� 5   
   -   5         ��Name$ btEntra��5      $��Entra��6"   $
��Left=�62   $��230,294,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        $ btSale��5      $
��Sale��6!   $
��Left=�60   $��322,294,0,0q�6K   $	��Top=�6`   $��75��6x   6�   �� 5   
   -   5         ��Name$ cbListaPersonas��5      $
��Left=�6W   $��
20,292,0,0q�6r   $	��Top=�6�   $	��187��6�   ��6,   �� $ ListaPersonas�6�   o� 5   
   -   5         o�Name$ 	mnMenuApp��5      $��24��6"   $��
20,10,21,0q�6.   $	��Top=�6B   .@�5      m� -   5         m�Name$ itemAdd��5      $��Añadir��6(   $��24��68   $��80��6D   6O   5      5      5      