   M S B A M L   `   `   `  ����d  `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF  5   	    ChiringuitoWPF!   ChiringuitoWPF.winBranchReg   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	    � Title$ winBranchReg��5   	   $	��700��5   	   $
��1000��5   	   ���	#FFF3F3F3 � WindowStartupLocation$ CenterScreen=�6D    � 
ResizeMode$ NoResize=�6i    � WindowStyle$
 None=�6    � 	Resources 5        CiudadComboBoxStyle �� 
TargetType �� BasedOn	 �� Property
 �� Value  TipoComboBoxStyle&   System.Windows.Controls.DataGrid-  'MaterialDesignThemes.Wpf.DataGridAssist  MaterialDesignPaper  MaterialDesignDivider=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%   &	       7��&	 �     7��'  9    7 '  S    7 �� 5   
   " ��6,   8   .�5      �� 	 � ��

 � � �6+   �� 5      	 � ��

 �   �6+   �� 5      	 � ��$
 Arial)�6+   5      �� 5   
   " ��6*   8   .�5      �� 	 � ��

 ��  �6+   �� 5      	 � ��

 �   �6+   �� 5       	 � ��$
 Tahoma)�6+   5"      �� 5#   
   "  6   8   .�5$      �� 	 �@ CellPadding$
 8q�6J   �� 5%      	 �@ ColumnHeaderPadding$
 12q�6R   �� 5&      	 � ��#
 �  6+   �� 5'      	 � ��#
 �   6+   �� 5(      	 � ��#
 �  6+   �� 5)      	 �@ RowBackground#
 �  6.   �� 5*       	 �@ AlternatingRowBackground#
 �  69   �� 5+       	 �@ HorizontalGridLinesBrush#
 �  69   �� 5,      	 �@ VerticalGridLinesBrush#
 �  67   �� 5-      	 � ��#
 �  6,   �� 5.      	 � ��$
 1q�60   5/      �� 50   
   "  6   8   .�51      �� 	 � ��$
 Center=�6;   �� 52      	 � ��$
 12q�6(   53      54      ��55      �� 56   
    �� ImageSource$ /pantalla.png��6   .��59      �  � RowDefinitions 5:   
   �� 5;      $
��Auto �6   �� 5<      $��* �6    � ColumnDefinitions 5>   
   �� 5?      $��* �6   �� 5@      $��* �6   .+�5D   
   �� $
��Left=�6   $	��214��6/   $��30,0,0,0q�6<   
���   �$��Center=�6]   $	��310��6x   ���	#FFF7BFBF6�   �� 5G   
   -   5         ��Name$ 	leftStack��5G       �� Orientation$ Vertical=�6(   $
��Left=�6?   $��10,0,0,0q�6Z   $	��Top=�6l   .+�5H      �� $ 
Horizontal=�6   $��50��62   $	��313��6>   $��0,0,0,0q�6J   .+�5I      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�6*   
�������$��Center=�6L   $��0,0,10,0q�6g   $��22��6y   $��22��6�   �� 5J      -   5         ��Name$ textName��5J      
���   � % !MaterialDesignFloatingHintTextBox#��[ 6?   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre Sucursal��6z   $	��280��6�   $��50��6�   $
��Bold"�6�   $��18(�6�   $��Arial)�6�   5K      �� 5L      $ 
Horizontal=�6   $��50��62   $	��313��6>   $��0,30,0,0q�6J   .+�5M        $ Account=�6*   
�������$��Center=�6L   $��0,0,10,0q�6g   $��22��6y   $��22��6�   �� 5N      -   5        $ 
textAdress��5N      
���   �#��[ 6A   $ Dirección Sucursal��6|   $	��280��6�   $��50��6�   $
��Bold"�6�   $��18(�6�   $��Arial)�6�   5O      �� 5P      $ 
Horizontal=�6   $��50��62   $	��313��6>   $��0,30,0,0q�6J   .+�5Q        $ Account=�6*   
�������$��Center=�6L   $��0,0,10,0q�6g   $��22��6y   $��22��6�   �� 5R      -   5        $ 
textNumber��5R      ���	#FF0F0F0F#��[ 6E   $ Número De Contacto��6�   $	��280��6�   $��50��6�   $
��Bold"�6�   $��18(�6�   $��Arial)�6�   5S      5T      �� 5U   
   $��1��6   $
��Left=�6$   $	��134��6?   $��	29,10,0,0q�6L   
���   �$	��Top=�6n   $	��226��6�   ���	#FFF7BFBF6�   �� 5X   
   -   5        $ 
rightStack��5X      $ Vertical=�6)   $��Center=�6@   $��
0,10,250,0q�6]   $	��Top=�6q   $��1��6�   .+�5Y      �� $ 
Horizontal=�6   $��50��62   $	��313��6>   $��0,0,0,0q�6J   .+�5Z        $ LocationCity=�6*   
�������$��Center=�6Q   $��0,0,10,0q�6l   $��22��6~   $��22��6�   �� 5[      -   5         ��Name$ 	cbxCiudad��5[      #��[ 6.   
���   �$ Ciudad��6n   $	��280��6�   $��50��6�   $
��Bold"�6�   $��18(�6�   $��Arial)�6�   ��6�   Z� ��6�   Z� 5\      �� 5]      $ 
Horizontal=�6   $��50��62   $	��313��6>   $��0,30,0,0q�6J   .+�5^        $ Category=�6*   
�������$��Center=�6M   $��0,0,10,0q�6h   $��22��6z   $��22��6�   �� 5_      -   5        $ cbxTipo��5_      
���   �$
 Tipo��6?   $	��280��6e   $��50��6q   $
��Bold"�6}   $��18(�6�   $��Arial)�6�   5`      �� 5a      -	   5         ��Name$ 
btnGuardar��5a      $��Guardar��6)   $��	10,15,0,0q�6;   $��80��6g   �� 5b      -
   5        $ 	btnVolver��5b      $��Volver��6(   $��	10,15,0,0q�69   $��80��6d   5c      �� 5f   
   $	��229��6   $ Vertical=�6"   $��Right=�69   $	��Top=�6U   $��0,5,68,0q�6m   $��0��6   $��1��6�   $	��152��6�   .+�5g      �� -   5         ��Name$ uploadedImage��5g      $	��150��6+   $	��150��67   $��	0,0,10,10q�6D   �� 5h      -   5        $ btnSubirImagen��5h      $��
Subir Foto��6-   $��0,0,20,0q�6_   5i      '   !Microsoft.Maps.MapControl.WPF.Map  5m   
   -   5          Name$ MapSucu��5m   <   $	��820��6   $	��400��6   $��	0,0,120,0q�6)   $��1��6M   $��2��6Z   +   %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT	   NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$F @Amx8PT3sZiQyzwZW-tU4yO4ZnQ6fKLVUZ5ibQmCqbkMCBuBLr6pYCjbNwIwNlBJ3	 6n      Center<
   6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ -17.393639, -66.157195
 6�      	ZoomLevel$ 16Q�6�   6�   �� 5n   
   -   5        $ btnIn��5n      $��1��6    $��+��60   $
��Left=�6<   $��
423,83,0,0q�6W   $��1��6k   $	��Top=�6x   6�   �� 5o   
   -   5        $ btnOut��5o      $��1��6!   $��-��61   $
��Left=�6=   $��423,145,0,0q�6X   $��1��6m   $	��Top=�6z   6�   �� 5p   
   -   5        $ btnSatelite��5p      $��1��6&   $��Satelite��66   $
��Left=�6I   $��400,227,0,0q�6d   $��1��6y   $	��Top=�6�   6�   �� 5q   
   -   5        $ btnCalle��5q      $��1��6#   $��Calle��63   $
��Left=�6C   $��400,374,0,0q�6^   $��1��6s   $	��Top=�6�   6�   �� 5r   
   $��1��6   $��50��6!   $��50��6,   $
��Left=�68   $��	440,0,0,0q�6S   $	��Top=�6f   ��5s      �� 5t      $# /icone-fermer-et-x-noir-1.png��6   5v      5w      5x      