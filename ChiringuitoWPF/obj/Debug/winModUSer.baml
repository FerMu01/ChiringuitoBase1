   M S B A M L   `   `   `  ����I  EChiringuitoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ChiringuitoWPFChiringuitoWPF  5   	       ChiringuitoWPF.winModUSer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ChiringuitoWPF     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	    � Title$ 
winModUSer��5   	   $	��650��6   $
��1100��6)    � 
ResizeMode$ NoResize=�6M    � WindowStartupLocation$ CenterScreen=�6c    � WindowStyle$
 None=�6�   ��5   	   Z�  � 	Resources 5      &   System.Windows.Controls.DataGrid �� 
TargetType �� BasedOn-  'MaterialDesignThemes.Wpf.DataGridAssist	 �� Property
 �� Value  MaterialDesignPaper  MaterialDesignDivider=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '        7 '      7 �� 5   
   "  6   8   .�5      �� 	 �@ CellPadding$
 8q�6J   �� 5      	 �@ ColumnHeaderPadding$
 12q�6R   �� 5      	 � ��#
 �  6+   �� 5      	 � ��#
 �   6+   �� 5      	 � ��#
 �  6+   �� 5      	 �@ RowBackground#
 �  6.   �� 5       	 �@ AlternatingRowBackground#
 �  69   �� 5       	 �@ HorizontalGridLinesBrush#
 �  69   �� 5      	 �@ VerticalGridLinesBrush#
 �  67   �� 5      	 � ��#
 �  6,   �� 5      	 � ��$
 1q�60   5      �� 5   
   "  6   8   .�5       �� 	 � ��$
 Center=�6;   �� 5!      	 � ��$
 12q�6(   5"      5#      .��5$      � ��5%   
   �� 5&       �� ImageSource$ /pantalla.png��6   .+�5(   
     -   5          Name$ dvgData��5(      $	��700��6$   $	��480��60   $��6��6=      
IsReadOnly .    CanUserAddRows .     AutoGenerateColumns . $��0,100,350,0q�6�   $��2��6�   6�   �� 5)   
   -   5         ��Name$ 	btnDelete��5)      $��Borrar��6$   $
��Left=�65   $��850,500,0,0q�6P   $	��Top=�6e   6}   �� 5+   
   -   5         ��Name$ stackBox��5+       �� Orientation$ Vertical=�6'   $
��Left=�6>   $��790,170,0,0q�6Y   $	��Top=�6n   {�.  .+�5,      �� $ 
Horizontal=�6   $��40��62   $	��313��6>   $��0,0,0,0q�6J   .+�5-      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�6*   
�������$��Center=�6L   $��	0,20,10,0q�6g   $��Center=�6z   $��22��6�   $��22��6�   �� 5.      -   5         ��Name$ textName��5.      
������� % !MaterialDesignFloatingHintTextBox#��[ 6?   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre��6z   $	��280��6�   $��50��6�    �� SelectionOpacity$ 1Q�6�   $
��Bold"�6�   $��18(�6�   $��Arial)�6�   5/      �� 50      $ 
Horizontal=�6   $��40��62   $	��313��6>   $��0,30,0,0q�6J   .+�51        $ Account=�6*   
�������$��Center=�6L   $��	0,20,10,0q�6g   $��Center=�6z   $��22��6�   $��22��6�   �� 52      -   5        $ textLast��52      
�������#��[ 6?   $ Apellido��6z   $	��280��6�   $��50��6�   $ 1Q�6�   $
��Bold"�6�   $��18(�6�   $��Arial)�6�   53      �� 54      $ 
Horizontal=�6   $��40��62   $	��313��6>   $��0,30,0,0q�6J   .+�55        $ Account=�6*   
�������$��Center=�6L   $��	0,20,10,0q�6g   $��Center=�6z   $��22��6�   $��22��6�   �� 56      -   5        $ 
textSecond��56      
�������#��[ 6A   $ Segundo Apellido��6|   $	��280��6�   $��50��6�   $ 1Q�6�   $
��Bold"�6�   $��18(�6�   $��Arial)�6�   57      �� 58      $ 
Horizontal=�6   $��40��62   $	��313��6>   $��0,30,0,0q�6J   .+�59        $ Email=�6*   
�������$��Center=�6J   $��	0,20,10,0q�6e   $��Center=�6x   $��22��6�   $��22��6�   �� 5:      -   5        $ 	textEmail��5:      
�������#��[ 6@   $ Correo Electrónico��6{   $	��280��6�   $��50��6�   $ 1Q�6�   $
��Bold"�6�   $��18(�6�   $��Arial)�6�   5;      5<      �� 5>   
   $ 
Horizontal=�6   $��5��6.   $��Center=�6;   $��40��6V   $	��300��6b   $��750,300,0,0q�6n   .+�5?        $ Calendar=�6&   $��25��66   $��25��6A   
�������$��Center=�6`   $��	13,0,10,0q�6{   $��Center=�6�   (  "System.Windows.Controls.DatePicker  5@      -	   5          Name$ DatePickerFecha��5@      
������� ( $MaterialDesignFloatingHintDatePicker#��[ 6E   $ Fecha de Nacimiento��6�   $	��250��6�   $��40��6�      DisplayDate$ 
2006-05-17��6�      DisplayDateEnd$ 
2006-05-17X�6�   {�.  $
��Bold"�6  $��Arial)�6)  $��18(�6<  5A      �� 5C   
   -
   5        $ 
btnGuardar��5C      $��Guardar��6%   $
��Left=�67   $��980,500,0,0q�6R   $	��Top=�6g   6   �� 5D   
   -   5        $ 	btnUpdate��5D      $��
Actualizar��6$   $
��Left=�69   $��840,570,0,0q�6T   $	��Top=�6i   6�   �� 5E   
   -   5        $ 	btnVolver��5E      $��Regresar��6$   $
��Left=�67   $��980,570,0,0q�6R   $	��Top=�6g   6   �� 5F   
   -   5        $
��Left=�5F      $��1060,10,0,0q�6-   $	��Top=�6B   ��5G      �� 5I      $# /icone-fermer-et-x-noir-1.png��6   5K      5L      5M      