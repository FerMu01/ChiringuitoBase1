   M S B A M L   `   `   `  ����d  `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF  5   	   I EChiringuitoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ChiringuitoWPFChiringuitoWPF 5   	   !   ChiringuitoWPF.winBranchMod   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   `mRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ChiringuitoWPF     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	    � Title$ 	Modificar��5   	   $	��700��5   	   $
��1000��5   	    � 	Resources 5      &   System.Windows.Controls.DataGrid �� 
TargetType �� BasedOn-  'MaterialDesignThemes.Wpf.DataGridAssist �� Property �� Value  MaterialDesignPaper  MaterialDesignDivider=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '        7 '      7 �� 5   
   "  6   8   .�5      ��  �@ CellPadding$ 8q�6J   �� 5       �@ ColumnHeaderPadding$ 12q�6R   �� 5       � ��# �  6+   �� 5       � ��# �   6+   �� 5       � ��# �  6+   �� 5       �@ RowBackground# �  6.   �� 5        �@ AlternatingRowBackground# �  69   �� 5        �@ HorizontalGridLinesBrush# �  69   �� 5       �@ VerticalGridLinesBrush# �  67   �� 5       � ��# �  6,   �� 5       � ��$ 1q�60   5       �� 5!   
   "  6   8   .�5"      ��  � ��$ Center=�6;   �� 5#       � ��$ 12q�6(   5$      5%      ��5&      �� 5'   
    �� ImageSource$ /pantalla.png��6   .��5)      � 	 � RowDefinitions	 5*   
   �� 5+      $
��Auto �6   �� 5,      $
��Auto �6   �� 5-      $��* �6   
 � ColumnDefinitions
 5/   
   �� 50      $��* �6   �� 51      $��* �6   .+�54   
   �� $
��Left=�6   $	��357��6/   $��	33,20,0,0q�6<   $��2��6O   $��1��6`   
���   �$	��Top=�6|   $	��222��6�   ���	#FFF7BFBF6�   �� 56   
   -   5         ��Name$ 	leftStack��56       �� Orientation$ Vertical=�6(   $
��Left=�6?   $��	10,10,0,0q�6Z   $	��Top=�6m   $��0��6�   $	��396��6�   $��3��6�   $	��250��6�   .+�57      �� $ 
Horizontal=�6   $��50��62   $	��313��6>   $��0,0,0,0q�6J   .+�58      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�6*   
�������$��Center=�6L   $��0,0,10,0q�6g   $��22��6y   $��22��6�   �� 59      -   5         ��Name$ textName��59      
���   � % !MaterialDesignFloatingHintTextBox#��[ 6?   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre Sucursal��6z   $	��280��6�   $��50��6�   $
��Bold"�6�   $��18(�6�   $��Arial)�6�   5:      �� 5;      $ 
Horizontal=�6   $��50��62   $	��313��6>   $��0,30,0,0q�6J   .+�5<        $ Account=�6*   
�������$��Center=�6L   $��0,0,10,0q�6g   $��22��6y   $��22��6�   �� 5=      -   5        $ 
textAdress��5=      
���   �#��[ 6A   $ Dirección Sucursal��6|   $	��280��6�   $��50��6�   $
��Bold"�6�   $��18(�6�   $��Arial)�6�   5>      �� 5?      $ 
Horizontal=�6   $��50��62   $	��313��6>   $��0,30,0,0q�6J   .+�5@        $ Account=�6*   
�������$��Center=�6L   $��0,0,10,0q�6g   $��22��6y   $��22��6�   �� 5A      -   5        $ 
textNumber��5A      
���   �#��[ 6A   $ Número De Contacto��6|   $	��280��6�   $��50��6�   $
��Bold"�6�   $��18(�6�   $��Arial)�6�   5B      �� 5C      $ 
Horizontal=�6   $��50��62   $	��313��6>   $��0,30,0,0q�6J   .+�5D        $ LocationCity=�6*   
�������$��Center=�6Q   $��0,0,10,0q�6l   $��22��6~   $��22��6�   �� 5E      -   5         ��Name$ 	cbxCiudad��5E      
���   �$ Ciudad��6A   $	��280��6i   $��50��6u   $
��Bold"�6�   $��18(�6�   $��Arial)�6�   5F      �� 5G      $ 
Horizontal=�6   $��50��62   $	��313��6>   $��0,30,0,0q�6J   .+�5H        $ Category=�6*   
�������$��Center=�6M   $��0,0,10,0q�6h   $��22��6z   $��22��6�   �� 5I      -   5        $ cbxTipo��5I      
���   �$
 Tipo��6?   $	��280��6e   $��50��6q   $
��Bold"�6}   $��18(�6�   $��Arial)�6�   5J      5K      �� 5M   
   -   5        $ 
rightStack��5M      $ Vertical=�6)   $��Right=�6@   $��	0,10,10,0q�6\   $	��Top=�6o   $��0��6�   $��1��6�   �� 5O   
   $��2��6   $ 
Horizontal=�6)   $��Center=�6B   $	��Top=�6_   $��0,20,0,0q�6w   $��1��6�   .+�5Q      �� -	   5         ��Name$ 	btnVolver��5Q      $��Volver��6(   $��10,0,0,0q�69   6K   5R        5S   
   -
   5          Name$ dvgData��5S      $��2��6$   $��2��61      
IsReadOnly .    CanUserAddRows .     AutoGenerateColumns . $	��720��6�   $��	230,0,0,0q�6�   6�   �� 5T   
   -   5        $ btnSave��5T      $��Guardar��6"   $
��Left=�64   $��
81,349,0,0q�6O   $��2��6c   $	��Top=�6p   6�   �� 5U   
   -   5        $ 	btnBorrar��5U      $��Borrar��6$   $
��Left=�65   $��
81,451,0,0q�6P   $��2��6d   $	��Top=�6q   6�   5V      5W      