   M S B A M L   `   `   `  ����I  EVideosAppFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VideosAppFinalVideosAppFinal  5   	   !    VideosAppFinal.DialogoLibro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:VideosAppFinal     5   	     � Title$  DialogoLibro��5   	   $��345.2��6   $	��452��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ labelTitulo��5
      $��Título:��6%   $
��Left=�67   $��	78,48,0,0q�6R   $	��Top=�6e   �� 5   
   -   5        $ 
labelAutor��5      $��Autor:��6$   $
��Left=�65   $��	80,98,0,0q�6P   $	��Top=�6c   �� 5   
   -   5        $ labelFechaEntrada��5      $��Fecha de entrada:��6+   $
��Left=�6G   $��
80,148,0,0q�6b   $	��Top=�6v   �� 5   
   -   5         ��Name$ textBoxTitulo��5      $
��Left=�6�   $��23��6�   $��
157,52,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6  ��6M   ��  �� Path$ Titulo� �� NotifyOnValidationError .  �� ValidatesOnDataErrors . 6  �� 5   
   -   5        $ textBoxAutor��5      $
��Left=�6�   $��23��6�   $��157,101,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6
  ��6L   �� $ Autor� .  . 6
  (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ datePickerFechaDeEntrada��5      $
��Left=�6b   $��216,150,0,0q�6}   $	��Top=�6�      SelectedDate 67   �� $ FechaEntrada�6�   �� 5   
   -   5        	 ��Name$	 buttonAceptar��5      $��Acecptar��6(   $
��Left=�6;   $��122,232,0,0q�6V   $	��Top=�6k   $��75��6�   6�   �� 5   
   -   5        $	 buttonCancelar��5      $��Cancelar��6)   $
��Left=�6<   $��243,232,0,0q�6W   $	��Top=�6l   $��75��6�   6�   5      5      